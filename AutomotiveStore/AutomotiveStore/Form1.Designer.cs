namespace AutomotiveStore
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LubeCheckBox = new System.Windows.Forms.CheckBox();
            this.OilCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.RadiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.ReplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.TireCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartsPriceTextBox = new System.Windows.Forms.TextBox();
            this.LaborPriceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutputServiceLaber = new System.Windows.Forms.Label();
            this.OutputParts = new System.Windows.Forms.Label();
            this.OutputTax = new System.Windows.Forms.Label();
            this.OutputTotalFee = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LubeCheckBox);
            this.groupBox1.Controls.Add(this.OilCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // LubeCheckBox
            // 
            this.LubeCheckBox.AutoSize = true;
            this.LubeCheckBox.Location = new System.Drawing.Point(7, 46);
            this.LubeCheckBox.Name = "LubeCheckBox";
            this.LubeCheckBox.Size = new System.Drawing.Size(132, 20);
            this.LubeCheckBox.TabIndex = 1;
            this.LubeCheckBox.Text = "Lube Job ($18.00)";
            this.LubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OilCheckBox
            // 
            this.OilCheckBox.AutoSize = true;
            this.OilCheckBox.Location = new System.Drawing.Point(7, 20);
            this.OilCheckBox.Name = "OilCheckBox";
            this.OilCheckBox.Size = new System.Drawing.Size(142, 20);
            this.OilCheckBox.TabIndex = 0;
            this.OilCheckBox.Text = "Oil Change ($26.00)";
            this.OilCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransmissionCheckBox);
            this.groupBox2.Controls.Add(this.RadiatorCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // TransmissionCheckBox
            // 
            this.TransmissionCheckBox.AutoSize = true;
            this.TransmissionCheckBox.Location = new System.Drawing.Point(6, 46);
            this.TransmissionCheckBox.Name = "TransmissionCheckBox";
            this.TransmissionCheckBox.Size = new System.Drawing.Size(192, 20);
            this.TransmissionCheckBox.TabIndex = 2;
            this.TransmissionCheckBox.Text = "Transmission Flush ($80.00)";
            this.TransmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadiatorCheckBox
            // 
            this.RadiatorCheckBox.AutoSize = true;
            this.RadiatorCheckBox.Location = new System.Drawing.Point(6, 21);
            this.RadiatorCheckBox.Name = "RadiatorCheckBox";
            this.RadiatorCheckBox.Size = new System.Drawing.Size(163, 20);
            this.RadiatorCheckBox.TabIndex = 1;
            this.RadiatorCheckBox.Text = "Radiator Flush ($30.00)";
            this.RadiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TireCheckBox);
            this.groupBox3.Controls.Add(this.ReplaceCheckBox);
            this.groupBox3.Controls.Add(this.InspectionCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // InspectionCheckBox
            // 
            this.InspectionCheckBox.AutoSize = true;
            this.InspectionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectionCheckBox.Location = new System.Drawing.Point(7, 19);
            this.InspectionCheckBox.Name = "InspectionCheckBox";
            this.InspectionCheckBox.Size = new System.Drawing.Size(137, 20);
            this.InspectionCheckBox.TabIndex = 2;
            this.InspectionCheckBox.Text = "Inspection ($15.00)";
            this.InspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplaceCheckBox
            // 
            this.ReplaceCheckBox.AutoSize = true;
            this.ReplaceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceCheckBox.Location = new System.Drawing.Point(7, 42);
            this.ReplaceCheckBox.Name = "ReplaceCheckBox";
            this.ReplaceCheckBox.Size = new System.Drawing.Size(177, 20);
            this.ReplaceCheckBox.TabIndex = 3;
            this.ReplaceCheckBox.Text = "Replace Muffler ($100.00)";
            this.ReplaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // TireCheckBox
            // 
            this.TireCheckBox.AutoSize = true;
            this.TireCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TireCheckBox.Location = new System.Drawing.Point(7, 65);
            this.TireCheckBox.Name = "TireCheckBox";
            this.TireCheckBox.Size = new System.Drawing.Size(153, 20);
            this.TireCheckBox.TabIndex = 4;
            this.TireCheckBox.Text = "Tire Rotation ($20.00)";
            this.TireCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LaborPriceTextBox);
            this.groupBox4.Controls.Add(this.PartsPriceTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(215, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // PartsPriceTextBox
            // 
            this.PartsPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsPriceTextBox.Location = new System.Drawing.Point(86, 26);
            this.PartsPriceTextBox.Name = "PartsPriceTextBox";
            this.PartsPriceTextBox.Size = new System.Drawing.Size(80, 22);
            this.PartsPriceTextBox.TabIndex = 2;
            // 
            // LaborPriceTextBox
            // 
            this.LaborPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaborPriceTextBox.Location = new System.Drawing.Point(86, 61);
            this.LaborPriceTextBox.Name = "LaborPriceTextBox";
            this.LaborPriceTextBox.Size = new System.Drawing.Size(80, 22);
            this.LaborPriceTextBox.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OutputTotalFee);
            this.groupBox5.Controls.Add(this.OutputTax);
            this.groupBox5.Controls.Add(this.OutputParts);
            this.groupBox5.Controls.Add(this.OutputServiceLaber);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(25, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 150);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Service and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tax (on parts)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Fees";
            // 
            // OutputServiceLaber
            // 
            this.OutputServiceLaber.AutoSize = true;
            this.OutputServiceLaber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputServiceLaber.Location = new System.Drawing.Point(145, 27);
            this.OutputServiceLaber.Name = "OutputServiceLaber";
            this.OutputServiceLaber.Size = new System.Drawing.Size(100, 18);
            this.OutputServiceLaber.TabIndex = 5;
            this.OutputServiceLaber.Text = "                              ";
            // 
            // OutputParts
            // 
            this.OutputParts.AutoSize = true;
            this.OutputParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputParts.Location = new System.Drawing.Point(145, 55);
            this.OutputParts.Name = "OutputParts";
            this.OutputParts.Size = new System.Drawing.Size(100, 18);
            this.OutputParts.TabIndex = 6;
            this.OutputParts.Text = "                              ";
            // 
            // OutputTax
            // 
            this.OutputTax.AutoSize = true;
            this.OutputTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputTax.ForeColor = System.Drawing.Color.Blue;
            this.OutputTax.Location = new System.Drawing.Point(145, 82);
            this.OutputTax.Name = "OutputTax";
            this.OutputTax.Size = new System.Drawing.Size(100, 18);
            this.OutputTax.TabIndex = 7;
            this.OutputTax.Text = "                              ";
            // 
            // OutputTotalFee
            // 
            this.OutputTotalFee.AutoSize = true;
            this.OutputTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputTotalFee.ForeColor = System.Drawing.Color.Red;
            this.OutputTotalFee.Location = new System.Drawing.Point(145, 111);
            this.OutputTotalFee.Name = "OutputTotalFee";
            this.OutputTotalFee.Size = new System.Drawing.Size(100, 18);
            this.OutputTotalFee.TabIndex = 8;
            this.OutputTotalFee.Text = "                              ";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(46, 408);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(174, 408);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(301, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 443);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LubeCheckBox;
        private System.Windows.Forms.CheckBox OilCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox TransmissionCheckBox;
        private System.Windows.Forms.CheckBox RadiatorCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox TireCheckBox;
        private System.Windows.Forms.CheckBox ReplaceCheckBox;
        private System.Windows.Forms.CheckBox InspectionCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox LaborPriceTextBox;
        private System.Windows.Forms.TextBox PartsPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label OutputTotalFee;
        private System.Windows.Forms.Label OutputTax;
        private System.Windows.Forms.Label OutputParts;
        private System.Windows.Forms.Label OutputServiceLaber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

