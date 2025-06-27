namespace Tensile_control
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
            this.textBoxFixedLoad = new System.Windows.Forms.TextBox();
            this.textBoxLive = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStretch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Left_click = new System.Windows.Forms.Button();
            this.Right_click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFixedLoad
            // 
            this.textBoxFixedLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFixedLoad.Location = new System.Drawing.Point(518, 267);
            this.textBoxFixedLoad.Name = "textBoxFixedLoad";
            this.textBoxFixedLoad.Size = new System.Drawing.Size(130, 35);
            this.textBoxFixedLoad.TabIndex = 0;
            // 
            // textBoxLive
            // 
            this.textBoxLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLive.Location = new System.Drawing.Point(477, 68);
            this.textBoxLive.Multiline = true;
            this.textBoxLive.Name = "textBoxLive";
            this.textBoxLive.Size = new System.Drawing.Size(231, 80);
            this.textBoxLive.TabIndex = 1;
            this.textBoxLive.TextChanged += new System.EventHandler(this.textBoxLive_TextChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(20, 55);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(306, 132);
            this.textBoxLog.TabIndex = 2;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistance.Location = new System.Drawing.Point(54, 261);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(189, 31);
            this.textBoxDistance.TabIndex = 3;
            this.textBoxDistance.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нагрузка в реальном часі";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фіксована нагузка зразку";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonStretch
            // 
            this.buttonStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStretch.Location = new System.Drawing.Point(20, 397);
            this.buttonStretch.Name = "buttonStretch";
            this.buttonStretch.Size = new System.Drawing.Size(254, 58);
            this.buttonStretch.TabIndex = 6;
            this.buttonStretch.Text = "Розтягнути зразок";
            this.buttonStretch.UseVisualStyleBackColor = true;
            this.buttonStretch.Click += new System.EventHandler(this.buttonStretch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "КГ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "КГ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вікно повідомлень";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введіть дистанцію відїзду";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "ММ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // Left_click
            // 
            this.Left_click.Location = new System.Drawing.Point(62, 298);
            this.Left_click.Name = "Left_click";
            this.Left_click.Size = new System.Drawing.Size(75, 23);
            this.Left_click.TabIndex = 12;
            this.Left_click.Text = "Ліво";
            this.Left_click.UseVisualStyleBackColor = true;
            this.Left_click.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // Right_click
            // 
            this.Right_click.Location = new System.Drawing.Point(158, 298);
            this.Right_click.Name = "Right_click";
            this.Right_click.Size = new System.Drawing.Size(75, 23);
            this.Right_click.TabIndex = 13;
            this.Right_click.Text = "право";
            this.Right_click.UseVisualStyleBackColor = true;
            this.Right_click.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Нагрузити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonFixedLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Right_click);
            this.Controls.Add(this.Left_click);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStretch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxLive);
            this.Controls.Add(this.textBoxFixedLoad);
            this.Name = "Form1";
            this.Text = "Form1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFixedLoad;
        private System.Windows.Forms.TextBox textBoxLive;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStretch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Left_click;
        private System.Windows.Forms.Button Right_click;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

