﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

//R2724
//Prog 1
//Sept 22.
//01

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            const double labor = 3.25;      // defined formula constants
            const double under_cost = 4.25;
            const double waste_per = .10;
            const double sq_yrd = 9; 
            double width_txt_P, length_txt_P, price_per_sq_P, sq_yrd_form, hardwood_form, underlayment_form, labor_form, total_form; //defined varibles
            int underlayment_P, first_P;

            width_txt_P = double.Parse(width_txt.Text);    //Parsed everything from txt boxes
            length_txt_P = double.Parse(length_txt.Text);
            price_per_sq_P = double.Parse(price_per_sqfoot_txt.Text);
            underlayment_P = int.Parse(underlayment_txt.Text);
            first_P = int.Parse(first_room_txt.Text);

            sq_yrd_form = (width_txt_P * length_txt_P) / sq_yrd;   //formulas
            hardwood_form = sq_yrd_form * price_per_sq_P;
            hardwood_form = hardwood_form + (hardwood_form * waste_per);
            underlayment_form = sq_yrd_form * under_cost;
            labor_form = (sq_yrd_form * labor); 

            if (underlayment_P == 0)    //If statements for the Underlayment and first floor
            {
                underlayment_form = 0; 
            }
            if (first_P == 1)
            {
                labor_form = labor_form + 50;
            }

            total_form = hardwood_form + underlayment_form + labor_form; 


            sq_yards_output.Text = $"{sq_yrd_form:N1}";         //Displaying Formulas
            hardwood_cost_output.Text = $"{hardwood_form:C2}";
            underlay_cost_output.Text = $"{underlayment_form:C2}";
            labor_cost_output.Text = $"{labor_form:C2}";
            total_output.Text = $"{total_form:C2}";







        }
    }
}
