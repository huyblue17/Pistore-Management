using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PiStoreManagement.Control
{
    public partial class ChartControl : UserControl
    {
        PiStoreEntities db = new PiStoreEntities();

        public ChartControl()
        {
            InitializeComponent();

            cbTime.Items.Add("Daily");
            cbTime.Items.Add("Monthly");
            cbTime.Items.Add("Yearly");
            cbTime.SelectedIndex = 0;

            LoadColChart();
            LoadPieChart();
        }

        private void LoadColChart()
        {
            string selectedPeriod = cbTime.SelectedItem.ToString();
            var incomeData = GetIncomeData(selectedPeriod);

            // Clear previous series
            chartIncome.Series.Clear();

            // Create a new series for the chart
            var series = new Series("Total Income")
            {
                ChartType = SeriesChartType.Column // Choose the chart type you want
            };

            // Add data points to the series
            foreach (var data in incomeData)
            {
                series.Points.AddXY(data.Key, data.Value);
            }

            // Add the series to the chart
            chartIncome.Series.Add(series);

            // Configure chart appearance
            chartIncome.ChartAreas[0].AxisX.Title = selectedPeriod;
            chartIncome.ChartAreas[0].AxisY.Title = "Total Income";
            chartIncome.ChartAreas[0].AxisX.Interval = 1; // Set interval for X-axis labels

            chartIncome.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Disable X axis grid
            chartIncome.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Disable Y axis grid

        }

        private IQueryable<KeyValuePair<string, decimal>> GetIncomeData(string period)
        {
            // Fetch all bills with BillDate
            var bills = db.Bills
                          .Where(b => b.BillDate.HasValue)
                          .ToList(); // Load into memory

            switch (period)
            {
                case "Daily":
                    return bills
                            .GroupBy(b => b.BillDate.Value.ToString("yyyy-MM-dd")) // Group by each day
                            .Select(g => new KeyValuePair<string, decimal>(g.Key, g.Sum(b => (decimal)b.BTotalPrice))) // Calculate total income for each day
                            .OrderBy(g => DateTime.TryParse(g.Key, out DateTime date) ? date : DateTime.MinValue) // Safely parse the date for ordering
                            .AsQueryable();

                case "Monthly":
                    return bills
                            .GroupBy(b => b.BillDate.Value.ToString("yyyy-MM")) // Group by each month
                            .Select(g => new KeyValuePair<string, decimal>(g.Key, g.Sum(b => (decimal)b.BTotalPrice))) // Calculate total income for each month
                            .OrderBy(g => DateTime.TryParse(g.Key + "-01", out DateTime monthDate) ? monthDate : DateTime.MinValue) // Safely parse for ordering
                            .AsQueryable();

                case "Yearly":
                    return bills
                            .GroupBy(b => b.BillDate.Value.Year.ToString()) // Group by each year
                            .Select(g => new KeyValuePair<string, decimal>(g.Key, g.Sum(b => (decimal)b.BTotalPrice))) // Calculate total income for each year
                            .OrderBy(g => int.Parse(g.Key)) // Order by year
                            .AsQueryable();

                default:
                    return Enumerable.Empty<KeyValuePair<string, decimal>>().AsQueryable(); // Return an empty queryable
            }
        }


        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColChart();
        }


        private void LoadPieChart()
        {
            
            var productSalesData = GetProductSalesData();

            chartProduct.Series.Clear();

            
            var series = new Series("Products Sold")
            {
                ChartType = SeriesChartType.Pie 
            };

           
            foreach (var data in productSalesData)
            {
                series.Points.AddXY(data.Key, data.Value);
            }

            chartProduct.Series.Add(series);

            chartProduct.Titles.Clear();
            chartProduct.Titles.Add("Total Products Sold");

            chartProduct.ChartAreas[0].Area3DStyle.Enable3D = true; 
        }

        private List<KeyValuePair<string, int>> GetProductSalesData()
        {
            var productSales = db.OrderItems
                                 .GroupBy(oi => oi.Product.Pname) 
                                 .Select(g => new { ProductName = g.Key, TotalQuantity = g.Sum(oi => oi.Quantity) }) 
                                 .ToList() // Execute the query and get the result in memory
                                 .Select(g => new KeyValuePair<string, int>(g.ProductName, (int)g.TotalQuantity)) 
                                 .ToList();

            return productSales;
        }


        public void UpdateCharts()
        {
            LoadColChart(); 
            LoadPieChart(); 
        }

    }
}
