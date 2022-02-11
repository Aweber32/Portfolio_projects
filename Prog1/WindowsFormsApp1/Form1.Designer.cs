namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Program_Label = new System.Windows.Forms.Label();
            this.max_width_label = new System.Windows.Forms.Label();
            this.max_length_label = new System.Windows.Forms.Label();
            this.price_per_sqfoot = new System.Windows.Forms.Label();
            this.underlayment = new System.Windows.Forms.Label();
            this.first_room = new System.Windows.Forms.Label();
            this.yes_no = new System.Windows.Forms.Label();
            this.yes_no1 = new System.Windows.Forms.Label();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.length_txt = new System.Windows.Forms.TextBox();
            this.price_per_sqfoot_txt = new System.Windows.Forms.TextBox();
            this.underlayment_txt = new System.Windows.Forms.TextBox();
            this.first_room_txt = new System.Windows.Forms.TextBox();
            this.sq_yards = new System.Windows.Forms.Label();
            this.hardwood_cost = new System.Windows.Forms.Label();
            this.underlay_cost = new System.Windows.Forms.Label();
            this.labor_cost = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.sq_yards_output = new System.Windows.Forms.Label();
            this.hardwood_cost_output = new System.Windows.Forms.Label();
            this.underlay_cost_output = new System.Windows.Forms.Label();
            this.labor_cost_output = new System.Windows.Forms.Label();
            this.total_output = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Program_Label
            // 
            this.Program_Label.AutoSize = true;
            this.Program_Label.Location = new System.Drawing.Point(126, 36);
            this.Program_Label.Name = "Program_Label";
            this.Program_Label.Size = new System.Drawing.Size(499, 32);
            this.Program_Label.TabIndex = 0;
            this.Program_Label.Text = "EZ-Hardwood Flooring Price Estimator";
            // 
            // max_width_label
            // 
            this.max_width_label.AutoSize = true;
            this.max_width_label.Location = new System.Drawing.Point(41, 138);
            this.max_width_label.Name = "max_width_label";
            this.max_width_label.Size = new System.Drawing.Size(310, 32);
            this.max_width_label.TabIndex = 1;
            this.max_width_label.Text = "Max Width of Room (ft):";
            // 
            // max_length_label
            // 
            this.max_length_label.AutoSize = true;
            this.max_length_label.Location = new System.Drawing.Point(26, 228);
            this.max_length_label.Name = "max_length_label";
            this.max_length_label.Size = new System.Drawing.Size(325, 32);
            this.max_length_label.TabIndex = 2;
            this.max_length_label.Text = "Max Length of Room (ft);";
            // 
            // price_per_sqfoot
            // 
            this.price_per_sqfoot.AutoSize = true;
            this.price_per_sqfoot.Location = new System.Drawing.Point(27, 331);
            this.price_per_sqfoot.Name = "price_per_sqfoot";
            this.price_per_sqfoot.Size = new System.Drawing.Size(324, 32);
            this.price_per_sqfoot.TabIndex = 3;
            this.price_per_sqfoot.Text = "Hardwood Price (sq. yd):";
            // 
            // underlayment
            // 
            this.underlayment.AutoSize = true;
            this.underlayment.Location = new System.Drawing.Point(151, 422);
            this.underlayment.Name = "underlayment";
            this.underlayment.Size = new System.Drawing.Size(200, 32);
            this.underlayment.TabIndex = 4;
            this.underlayment.Text = "Underlayment:";
            // 
            // first_room
            // 
            this.first_room.AutoSize = true;
            this.first_room.Location = new System.Drawing.Point(191, 523);
            this.first_room.Name = "first_room";
            this.first_room.Size = new System.Drawing.Size(160, 32);
            this.first_room.TabIndex = 5;
            this.first_room.Text = "First Room:";
            // 
            // yes_no
            // 
            this.yes_no.AutoSize = true;
            this.yes_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_no.Location = new System.Drawing.Point(170, 463);
            this.yes_no.Name = "yes_no";
            this.yes_no.Size = new System.Drawing.Size(172, 25);
            this.yes_no.TabIndex = 6;
            this.yes_no.Text = "(1 = YES, 0 = NO)";
            // 
            // yes_no1
            // 
            this.yes_no1.AutoSize = true;
            this.yes_no1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_no1.Location = new System.Drawing.Point(170, 566);
            this.yes_no1.Name = "yes_no1";
            this.yes_no1.Size = new System.Drawing.Size(172, 25);
            this.yes_no1.TabIndex = 7;
            this.yes_no1.Text = "(1 = YES, 0 = NO)";
            // 
            // width_txt
            // 
            this.width_txt.Location = new System.Drawing.Point(410, 138);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(310, 38);
            this.width_txt.TabIndex = 8;
            // 
            // length_txt
            // 
            this.length_txt.Location = new System.Drawing.Point(410, 228);
            this.length_txt.Name = "length_txt";
            this.length_txt.Size = new System.Drawing.Size(310, 38);
            this.length_txt.TabIndex = 9;
            // 
            // price_per_sqfoot_txt
            // 
            this.price_per_sqfoot_txt.Location = new System.Drawing.Point(410, 331);
            this.price_per_sqfoot_txt.Name = "price_per_sqfoot_txt";
            this.price_per_sqfoot_txt.Size = new System.Drawing.Size(310, 38);
            this.price_per_sqfoot_txt.TabIndex = 10;
            // 
            // underlayment_txt
            // 
            this.underlayment_txt.Location = new System.Drawing.Point(410, 422);
            this.underlayment_txt.Name = "underlayment_txt";
            this.underlayment_txt.Size = new System.Drawing.Size(310, 38);
            this.underlayment_txt.TabIndex = 11;
            // 
            // first_room_txt
            // 
            this.first_room_txt.Location = new System.Drawing.Point(410, 523);
            this.first_room_txt.Name = "first_room_txt";
            this.first_room_txt.Size = new System.Drawing.Size(310, 38);
            this.first_room_txt.TabIndex = 12;
            // 
            // sq_yards
            // 
            this.sq_yards.AutoSize = true;
            this.sq_yards.Location = new System.Drawing.Point(204, 726);
            this.sq_yards.Name = "sq_yards";
            this.sq_yards.Size = new System.Drawing.Size(147, 32);
            this.sq_yards.TabIndex = 13;
            this.sq_yards.Text = "Sq. Yards:";
            // 
            // hardwood_cost
            // 
            this.hardwood_cost.AutoSize = true;
            this.hardwood_cost.Location = new System.Drawing.Point(134, 809);
            this.hardwood_cost.Name = "hardwood_cost";
            this.hardwood_cost.Size = new System.Drawing.Size(217, 32);
            this.hardwood_cost.TabIndex = 14;
            this.hardwood_cost.Text = "Hardwood Cost:";
            // 
            // underlay_cost
            // 
            this.underlay_cost.AutoSize = true;
            this.underlay_cost.Location = new System.Drawing.Point(149, 894);
            this.underlay_cost.Name = "underlay_cost";
            this.underlay_cost.Size = new System.Drawing.Size(202, 32);
            this.underlay_cost.TabIndex = 15;
            this.underlay_cost.Text = "Underlay Cost:";
            // 
            // labor_cost
            // 
            this.labor_cost.AutoSize = true;
            this.labor_cost.Location = new System.Drawing.Point(181, 984);
            this.labor_cost.Name = "labor_cost";
            this.labor_cost.Size = new System.Drawing.Size(161, 32);
            this.labor_cost.TabIndex = 16;
            this.labor_cost.Text = "Labor Cost:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(188, 1067);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(163, 32);
            this.total.TabIndex = 17;
            this.total.Text = "Total Cost:";
            // 
            // sq_yards_output
            // 
            this.sq_yards_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sq_yards_output.Location = new System.Drawing.Point(410, 726);
            this.sq_yards_output.Name = "sq_yards_output";
            this.sq_yards_output.Size = new System.Drawing.Size(310, 44);
            this.sq_yards_output.TabIndex = 18;
            // 
            // hardwood_cost_output
            // 
            this.hardwood_cost_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hardwood_cost_output.Location = new System.Drawing.Point(410, 809);
            this.hardwood_cost_output.Name = "hardwood_cost_output";
            this.hardwood_cost_output.Size = new System.Drawing.Size(310, 44);
            this.hardwood_cost_output.TabIndex = 19;
            // 
            // underlay_cost_output
            // 
            this.underlay_cost_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underlay_cost_output.Location = new System.Drawing.Point(410, 894);
            this.underlay_cost_output.Name = "underlay_cost_output";
            this.underlay_cost_output.Size = new System.Drawing.Size(310, 44);
            this.underlay_cost_output.TabIndex = 20;
            // 
            // labor_cost_output
            // 
            this.labor_cost_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labor_cost_output.Location = new System.Drawing.Point(410, 984);
            this.labor_cost_output.Name = "labor_cost_output";
            this.labor_cost_output.Size = new System.Drawing.Size(310, 44);
            this.labor_cost_output.TabIndex = 21;
            // 
            // total_output
            // 
            this.total_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_output.Location = new System.Drawing.Point(410, 1067);
            this.total_output.Name = "total_output";
            this.total_output.Size = new System.Drawing.Size(310, 44);
            this.total_output.TabIndex = 22;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(242, 1188);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(334, 57);
            this.calc_button.TabIndex = 23;
            this.calc_button.Text = "Calculate Estimate";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 1343);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.total_output);
            this.Controls.Add(this.labor_cost_output);
            this.Controls.Add(this.underlay_cost_output);
            this.Controls.Add(this.hardwood_cost_output);
            this.Controls.Add(this.sq_yards_output);
            this.Controls.Add(this.total);
            this.Controls.Add(this.labor_cost);
            this.Controls.Add(this.underlay_cost);
            this.Controls.Add(this.hardwood_cost);
            this.Controls.Add(this.sq_yards);
            this.Controls.Add(this.first_room_txt);
            this.Controls.Add(this.underlayment_txt);
            this.Controls.Add(this.price_per_sqfoot_txt);
            this.Controls.Add(this.length_txt);
            this.Controls.Add(this.width_txt);
            this.Controls.Add(this.yes_no1);
            this.Controls.Add(this.yes_no);
            this.Controls.Add(this.first_room);
            this.Controls.Add(this.underlayment);
            this.Controls.Add(this.price_per_sqfoot);
            this.Controls.Add(this.max_length_label);
            this.Controls.Add(this.max_width_label);
            this.Controls.Add(this.Program_Label);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Program_Label;
        private System.Windows.Forms.Label max_width_label;
        private System.Windows.Forms.Label max_length_label;
        private System.Windows.Forms.Label price_per_sqfoot;
        private System.Windows.Forms.Label underlayment;
        private System.Windows.Forms.Label first_room;
        private System.Windows.Forms.Label yes_no;
        private System.Windows.Forms.Label yes_no1;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.TextBox length_txt;
        private System.Windows.Forms.TextBox price_per_sqfoot_txt;
        private System.Windows.Forms.TextBox underlayment_txt;
        private System.Windows.Forms.TextBox first_room_txt;
        private System.Windows.Forms.Label sq_yards;
        private System.Windows.Forms.Label hardwood_cost;
        private System.Windows.Forms.Label underlay_cost;
        private System.Windows.Forms.Label labor_cost;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label sq_yards_output;
        private System.Windows.Forms.Label hardwood_cost_output;
        private System.Windows.Forms.Label underlay_cost_output;
        private System.Windows.Forms.Label labor_cost_output;
        private System.Windows.Forms.Label total_output;
        private System.Windows.Forms.Button calc_button;
    }
}

