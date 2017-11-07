//
// N-tier C# and SQL program to analyze CTA Ridership data.
//
// Kevin Tsao / ktsao5
// U. of Illinois, Chicago
// CS341, Fall 2016
// Homework 7
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs341_ktsao5_hwk6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string filename = this.txtDatabaseFilename.Text;

                BusinessTier.Business bizTier;
                bizTier = new BusinessTier.Business(filename);
                bizTier.TestConnection();
            }
            catch
            {
                // Not necessary, just testing the connection only.
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.GetStations();
            int count = 0;
            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
                count++;
            }
            StationNum.Text = "Number of stations: " + count;
        }

        private void stationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stationBox.SelectedIndex < 0)
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.GetStations();
            string stationName = Convert.ToString(stationBox.SelectedItem);
            int stationID = bizTier.GetStationByName(stationName);
            var stops = bizTier.GetStops(stationID);

            foreach (var stop in stops)
            {
                this.stopBox.Items.Add(stop.Name);
            }

            Int64 total = bizTier.GetTotalRidership();
            Int64 week = bizTier.GetWeekly(stationID);
            Int64 sat = bizTier.GetSat(stationID);
            Int64 sun = bizTier.GetSun(stationID);
            Int64 riders = bizTier.GetRiders(stationID);
            Int64 current = week + sat + sun;
            Double avg = current / riders;
            Double percent = Math.Round((100 * (Convert.ToDouble(current) / Convert.ToDouble(total))), 2);
            riderBox.Text = (current.ToString("#,##0"));
            avgBox.Text = (avg.ToString("#,##0") + "/day");
            percBox.Text = (percent.ToString() + "%");
            weekBox.Text = (week.ToString("#,##0"));
            satBox.Text = (sat.ToString("#,##0"));
            sunBox.Text = (sun.ToString("#,##0"));
        }

        private void stopBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stopBox.SelectedIndex < 0)
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);

            string name = Convert.ToString(stopBox.SelectedItem);
            lineBox.Items.Clear();
            DataSet lines = bizTier.GetLines(name);
            foreach (DataRow line in lines.Tables["TABLE"].Rows)
            {
                string color = string.Format("{0}", Convert.ToString(line["Color"]));
                lineBox.Items.Add(color);
            }

            DataRow row = bizTier.GetStopInfo(name);
            string direction = string.Format("{0}", Convert.ToString(row["Direction"]));
            string ada = string.Format("{0}", row["ADA"]);
            string lat = string.Format("{0}", Convert.ToDouble(row["Latitude"]));
            string lng = string.Format("{0}", Convert.ToDouble(row["Longitude"]));
            if (ada.Equals("True"))
            {
                handicapBox.Text = "Yes";
            }
            else
            {
                handicapBox.Text = "No";
            }
            directBox.Text = direction;
            string location = "(" + lat + ", " + lng + ")";
            locationBox.Text = location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            var stations = bizTier.GetTopStations(10);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
            }
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.GetTopWeekly();
            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
            }
        }

        private void satButton_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.GetTopSat();
            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
            }
        }

        private void shButton_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.GetTopSun();
            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
            }
        }

        private void findByName_Click(object sender, EventArgs e)
        {
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            stationBox.Items.Clear(); handicapBox.Clear(); directBox.Clear(); locationBox.Clear(); lineBox.Items.Clear(); stopBox.Items.Clear();
            riderBox.Clear(); avgBox.Clear(); percBox.Clear(); weekBox.Clear(); satBox.Clear(); sunBox.Clear();

            var stations = bizTier.FindByName(userInput.Text);
            foreach (var station in stations)
            {
                this.stationBox.Items.Add(station.Name);
            }
        }

        private void flipADA_Click(object sender, EventArgs e)
        {
            if (stopBox.SelectedIndex < 0)
                return;
            BusinessTier.Business bizTier = new BusinessTier.Business(this.txtDatabaseFilename.Text);
            string name = Convert.ToString(stopBox.SelectedItem);

            DataRow row = bizTier.GetStopInfo(name);
            string ada = string.Format("{0}", row["ADA"]);

            if (ada.Equals("True"))
            {
                handicapBox.Text = "No";
                bizTier.ChangeADA(name, 1);
            }
            else
            {
                handicapBox.Text = "Yes";
                bizTier.ChangeADA(name, 0);
            }
        }
    }
}
