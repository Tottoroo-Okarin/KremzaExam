using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ExamKremza
{
    public partial class Form1 : Form
    {


        

        List<string> flightID;
        List<string> planeDeparture;
        List<string> planeDestination;
        List<string> planeDate;
        List<string> planeTime;
        List<string> planeCapacity;
        List<string> planeBrigade;

        List<string> mod_flightID;
        List<string> mod_planeDeparture;
        List<string> mod_planeDestination;
        List<string> mod_planeDate;
        List<string> mod_planeTime;
        List<string> mod_planeCapacity;
        List<string> mod_planeBrigade;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            flightID = new List<string>();
            planeDeparture = new List<string>();
            planeDestination = new List<string>();
            planeDate = new List<string>();
            planeTime = new List<string>();
            planeCapacity = new List<string>();
            planeBrigade = new List<string>();

            using (StreamReader sr = new StreamReader("planes.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] t = line.Split(' ');

                    flightID.Add(t[0]);
                    planeDeparture.Add(t[1]);
                    planeDestination.Add(t[2]);
                    planeDate.Add(t[3]);
                    planeTime.Add(t[4]);
                    planeCapacity.Add(t[5]);
                    planeBrigade.Add(t[6]);
                }
            }

            mod_flightID = flightID;
            mod_planeDeparture = planeDeparture;
            mod_planeDestination = planeDestination;
            mod_planeDate = planeDate;
            mod_planeTime = planeTime;
            mod_planeCapacity = planeCapacity;
            mod_planeBrigade = planeBrigade;


            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = flightID.Count;

            dataGridView1.Columns[0].Name = "Номер рейса";
            dataGridView1.Columns[1].Name = "Точка отправления";
            dataGridView1.Columns[2].Name = "Точка прибытия";
            dataGridView1.Columns[3].Name = "Дата";
            dataGridView1.Columns[4].Name = "Время";
            dataGridView1.Columns[5].Name = "Количество мест";
            dataGridView1.Columns[6].Name = "Номер бригады";

            for (int i = 0; i < flightID.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j == 0) dataGridView1.Rows[i].Cells[j].Value = mod_flightID[i];
                    else if (j == 1) dataGridView1.Rows[i].Cells[j].Value = mod_planeDeparture[i];
                    else if (j == 2) dataGridView1.Rows[i].Cells[j].Value = mod_planeDestination[i];
                    else if (j == 3) dataGridView1.Rows[i].Cells[j].Value = mod_planeDate[i];
                    else if (j == 4) dataGridView1.Rows[i].Cells[j].Value = mod_planeTime[i];
                    else if (j == 5) dataGridView1.Rows[i].Cells[j].Value = mod_planeCapacity[i];
                    else if (j == 6) dataGridView1.Rows[i].Cells[j].Value = mod_planeBrigade[i];
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) departureTB.Enabled = true;
            else departureTB.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) destinationTB.Enabled = true;
            else destinationTB.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) dateTB.Enabled = true;
            else dateTB.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) timeTB.Enabled = true;
            else timeTB.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) capacityTB.Enabled = true;
            else capacityTB.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) brigadeTB.Enabled = true;
            else brigadeTB.Enabled = false;
        }

        private void sortB_Click(object sender, EventArgs e)
        {           
            List<string> criteria = new List<string> { "", "", "", "", "", "" };
            List<int> passedPlanes = new List<int>();

            if (departureTB.Enabled && departureTB.Text != "") criteria[0] = departureTB.Text;
            if (destinationTB.Enabled && destinationTB.Text != "") criteria[1] = destinationTB.Text;
            if (dateTB.Enabled && dateTB.Text != "") criteria[2] = dateTB.Text;
            if (timeTB.Enabled && timeTB.Text != "") criteria[3] = timeTB.Text;
            if (capacityTB.Enabled && capacityTB.Text != "") criteria[4] = capacityTB.Text;
            if (brigadeTB.Enabled && brigadeTB.Text != "") criteria[5] = brigadeTB.Text;

            for(int i = 0; i < mod_flightID.Count; i++)
            {
                int points = 0;
                if(criteria[0] == "" || mod_planeDeparture[i] == criteria[0])
                {
                    points++;
                    if(criteria[1] == "" || mod_planeDestination[i] == criteria[1])
                    {
                        points++;
                        if (criteria[2] == "" || mod_planeDate[i] == criteria[2])
                        {
                            points++;
                            if (criteria[3] == "" || mod_planeTime[i] == criteria[3])
                            {
                                points++;
                                if (criteria[4] == "" || mod_planeCapacity[i] == criteria[4])
                                {
                                    points++;
                                    if (criteria[5] == "" || mod_planeBrigade[i] == criteria[5])
                                    {
                                        points++;
                                        if (points == 6) passedPlanes.Add(i);
                                    }
                                    
                                }
                               
                            }
                            
                        }
                        
                    }
                    
                }
                


            }

            if(passedPlanes.Count == 0)
            {
                dataGridView1.RowCount = 1;
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "";
                    }
                    
                }
                return;

            }
            else
            {
                dataGridView1.RowCount = passedPlanes.Count;
            }

            for (int i = 0; i < passedPlanes.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j == 0) dataGridView1.Rows[i].Cells[j].Value = mod_flightID[passedPlanes[i]];
                    else if (j == 1) dataGridView1.Rows[i].Cells[j].Value = mod_planeDeparture[passedPlanes[i]];
                    else if (j == 2) dataGridView1.Rows[i].Cells[j].Value = mod_planeDestination[passedPlanes[i]];
                    else if (j == 3) dataGridView1.Rows[i].Cells[j].Value = mod_planeDate[passedPlanes[i]];
                    else if (j == 4) dataGridView1.Rows[i].Cells[j].Value = mod_planeTime[passedPlanes[i]];
                    else if (j == 5) dataGridView1.Rows[i].Cells[j].Value = mod_planeCapacity[passedPlanes[i]];
                    else if (j == 6) dataGridView1.Rows[i].Cells[j].Value = mod_planeBrigade[passedPlanes[i]];
                }
            }
        }

        private void redB_Click(object sender, EventArgs e)
        {
            int id = mod_flightID.IndexOf(redNumberTB.Text);
            int idInTable = 0;
            if(id == -1)
            {
                MessageBox.Show("Такого рейса не существует!");
                return;
            }

            if (redDepartureTB.Text == "" || redDestinationTB.Text == "" || redDateTB.Text == "" || redTimeTB.Text == "" || redCapacityTB.Text == "" || redBrigadeTB.Text == "")
            {
                MessageBox.Show("Неверные вводные данные!");
                return;
            }

            mod_planeDeparture[id] = redDepartureTB.Text;
            mod_planeDestination[id] = redDestinationTB.Text;
            mod_planeDate[id] = redDateTB.Text;
            mod_planeTime[id] = redTimeTB.Text;
            mod_planeCapacity[id] = redCapacityTB.Text;
            mod_planeBrigade[id] = redBrigadeTB.Text;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == mod_flightID[id]) idInTable = i;
            }

            for (int i = 0; i < 7; i++)
            {
                if (i == 0) dataGridView1.Rows[idInTable].Cells[i].Value = mod_flightID[id];
                else if (i == 1) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeDeparture[id];
                else if (i == 2) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeDestination[id];
                else if (i == 3) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeDate[id];
                else if (i == 4) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeTime[id];
                else if (i == 5) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeCapacity[id];
                else if (i == 6) dataGridView1.Rows[idInTable].Cells[i].Value = mod_planeBrigade[id];
            }

            string record = "";
            

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string line = "";
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 6) line += (dataGridView1.Rows[i].Cells[j].Value + " ");
                    else line += dataGridView1.Rows[i].Cells[j].Value;
                }
                if (i != dataGridView1.Rows.Count - 1) record += (line + "\n");
                else record += line;
            }
            

            using (StreamWriter sw = new StreamWriter("planes.txt", false))
            {
                sw.WriteLine(record);
            }
        }

        private void overviewB_Click(object sender, EventArgs e)
        {
            string record = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string line = "";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 6) line += (dataGridView1.Rows[i].Cells[j].Value + " ");
                    else line += dataGridView1.Rows[i].Cells[j].Value;
                }
                if (i != dataGridView1.Rows.Count - 1) record += (line + "\n");
                else record += line;
            }


            using (StreamWriter sw = new StreamWriter("overview.txt", false))
            {
                sw.WriteLine(record);
            }
        }
    }
        
}
