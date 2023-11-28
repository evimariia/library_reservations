using System.Windows.Forms;

namespace ReservasAPPv1
{
    partial class FormReserva
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 1;
            label1.Text = "Reserva de salas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 3;
            label2.Text = "Data ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 4;
            label3.Text = "Horário";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(30, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(210, 161);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 6;
            label4.Text = "Quantidade de pessoas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(210, 187);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 28);
            comboBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(283, 331);
            button1.Name = "button1";
            button1.Size = new Size(145, 33);
            button1.TabIndex = 8;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bt1_ClickAsync;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(30, 188);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(134, 27);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.Value = new DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(210, 81);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 11;
            label5.Text = "Tipo de sala";
            // 
            // button2
            // 
            button2.Location = new Point(133, 331);
            button2.Name = "button2";
            button2.Size = new Size(145, 33);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 393);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 12;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(210, 235);
            label7.Name = "label7";
            label7.Size = new Size(131, 23);
            label7.TabIndex = 13;
            label7.Text = "Número da sala";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(210, 261);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(217, 28);
            comboBox3.TabIndex = 14;
            // 
            // FormReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 441);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormReserva";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Button button2;
        private Label label6;
        private Label label7;
        private ComboBox comboBox3;
    }
}