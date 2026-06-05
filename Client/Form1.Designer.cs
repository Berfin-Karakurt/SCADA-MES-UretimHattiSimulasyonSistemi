namespace SonProjeClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRejectRate = new System.Windows.Forms.Label();
            this.lblEfficiency = new System.Windows.Forms.Label();
            this.lblReject = new System.Windows.Forms.Label();
            this.lblProduced = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblPacketLost = new System.Windows.Forms.Label();
            this.lblTotalAlarm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMotorBaslat = new System.Windows.Forms.Button();
            this.btnYenidenBaslat = new System.Windows.Forms.Button();
            this.btnSqlTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCADA / MES SIMÜLASYON SİSTEMİ   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAĞLANTI DURUMU: ";
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Location = new System.Drawing.Point(245, 68);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(44, 16);
            this.lblBaglanti.TabIndex = 2;
            this.lblBaglanti.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRETİM VERİLERİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sıcaklık     :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hız          :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Basınç       :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nem          :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "ÜRETİM TAKİBİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Üretilen Ürün :";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(26, 106);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(84, 44);
            this.btnBaglan.TabIndex = 11;
            this.btnBaglan.Text = "Bağlantıyı Kur";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(131, 106);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(84, 44);
            this.btnKes.TabIndex = 12;
            this.btnKes.Text = "Bağlantıyı Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(217, 375);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(36, 16);
            this.lblHumidity.TabIndex = 17;
            this.lblHumidity.Text = "Nem";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(217, 347);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(51, 16);
            this.lblPressure.TabIndex = 16;
            this.lblPressure.Text = "Basınç ";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(217, 314);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(29, 16);
            this.lblSpeed.TabIndex = 15;
            this.lblSpeed.Text = "Hız ";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(217, 262);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(41, 16);
            this.lblMotor.TabIndex = 14;
            this.lblMotor.Text = "Motor";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(214, 234);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(54, 16);
            this.lblTemp.TabIndex = 13;
            this.lblTemp.Text = "Sıcaklık";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Hatalı Ürün   :";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(567, 75);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(51, 16);
            this.lblAlarm.TabIndex = 23;
            this.lblAlarm.Text = "label13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Hata Oranı    :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Verimlilik    :";
            // 
            // lblRejectRate
            // 
            this.lblRejectRate.AutoSize = true;
            this.lblRejectRate.Location = new System.Drawing.Point(217, 583);
            this.lblRejectRate.Name = "lblRejectRate";
            this.lblRejectRate.Size = new System.Drawing.Size(44, 16);
            this.lblRejectRate.TabIndex = 27;
            this.lblRejectRate.Text = "label3";
            // 
            // lblEfficiency
            // 
            this.lblEfficiency.AutoSize = true;
            this.lblEfficiency.Location = new System.Drawing.Point(217, 552);
            this.lblEfficiency.Name = "lblEfficiency";
            this.lblEfficiency.Size = new System.Drawing.Size(51, 16);
            this.lblEfficiency.TabIndex = 26;
            this.lblEfficiency.Text = "label17";
            // 
            // lblReject
            // 
            this.lblReject.AutoSize = true;
            this.lblReject.Location = new System.Drawing.Point(217, 490);
            this.lblReject.Name = "lblReject";
            this.lblReject.Size = new System.Drawing.Size(51, 16);
            this.lblReject.TabIndex = 25;
            this.lblReject.Text = "label18";
            // 
            // lblProduced
            // 
            this.lblProduced.AutoSize = true;
            this.lblProduced.Location = new System.Drawing.Point(217, 461);
            this.lblProduced.Name = "lblProduced";
            this.lblProduced.Size = new System.Drawing.Size(51, 16);
            this.lblProduced.TabIndex = 24;
            this.lblProduced.Text = "label19";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "ALARM / OLAY KAYITLARI";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(399, 155);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(220, 116);
            this.listBoxLog.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(395, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "İSTATİSTİKLER";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(398, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Toplam Alarm      :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(395, 414);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Paket Kaybı       :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(546, 461);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 44);
            this.btnTemizle.TabIndex = 37;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // lblPacketLost
            // 
            this.lblPacketLost.AutoSize = true;
            this.lblPacketLost.Location = new System.Drawing.Point(540, 414);
            this.lblPacketLost.Name = "lblPacketLost";
            this.lblPacketLost.Size = new System.Drawing.Size(79, 16);
            this.lblPacketLost.TabIndex = 40;
            this.lblPacketLost.Text = "Paket Kaybı";
            // 
            // lblTotalAlarm
            // 
            this.lblTotalAlarm.AutoSize = true;
            this.lblTotalAlarm.Location = new System.Drawing.Point(543, 357);
            this.lblTotalAlarm.Name = "lblTotalAlarm";
            this.lblTotalAlarm.Size = new System.Drawing.Size(92, 16);
            this.lblTotalAlarm.TabIndex = 38;
            this.lblTotalAlarm.Text = "Toplam Alarm";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(217, 206);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 16);
            this.lblTime.TabIndex = 43;
            this.lblTime.Text = "Zaman";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = "Zaman         :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 44;
            this.label21.Text = "Motor        :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "ALARM PANELİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "ANLIK SICAKLIK TAKİBİ:";
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(694, 124);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Crimson;
            series1.Legend = "Legend1";
            series1.Name = "Sicaklik";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Legend = "Legend1";
            series2.Name = "Hiz";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Series.Add(series2);
            this.chartTemp.Size = new System.Drawing.Size(300, 300);
            this.chartTemp.TabIndex = 46;
            this.chartTemp.Text = "chart1";
            // 
            // btnMotorBaslat
            // 
            this.btnMotorBaslat.Location = new System.Drawing.Point(39, 281);
            this.btnMotorBaslat.Name = "btnMotorBaslat";
            this.btnMotorBaslat.Size = new System.Drawing.Size(229, 23);
            this.btnMotorBaslat.TabIndex = 47;
            this.btnMotorBaslat.Text = "MOTORU ÇALIŞTIR";
            this.btnMotorBaslat.UseVisualStyleBackColor = true;
            this.btnMotorBaslat.Click += new System.EventHandler(this.btnMotorBaslat_Click);
            // 
            // btnYenidenBaslat
            // 
            this.btnYenidenBaslat.Location = new System.Drawing.Point(238, 106);
            this.btnYenidenBaslat.Name = "btnYenidenBaslat";
            this.btnYenidenBaslat.Size = new System.Drawing.Size(84, 44);
            this.btnYenidenBaslat.TabIndex = 49;
            this.btnYenidenBaslat.Text = "Üretimi Devam Ettir";
            this.btnYenidenBaslat.UseVisualStyleBackColor = true;
            this.btnYenidenBaslat.Click += new System.EventHandler(this.btnYenidenBaslat_Click);
            // 
            // btnSqlTest
            // 
            this.btnSqlTest.Location = new System.Drawing.Point(394, 461);
            this.btnSqlTest.Name = "btnSqlTest";
            this.btnSqlTest.Size = new System.Drawing.Size(134, 44);
            this.btnSqlTest.TabIndex = 50;
            this.btnSqlTest.Text = "SQL Kayıt";
            this.btnSqlTest.UseVisualStyleBackColor = true;
            this.btnSqlTest.Click += new System.EventHandler(this.btnSqlTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 721);
            this.Controls.Add(this.btnSqlTest);
            this.Controls.Add(this.btnYenidenBaslat);
            this.Controls.Add(this.btnMotorBaslat);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblPacketLost);
            this.Controls.Add(this.lblTotalAlarm);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRejectRate);
            this.Controls.Add(this.lblEfficiency);
            this.Controls.Add(this.lblReject);
            this.Controls.Add(this.lblProduced);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBaglanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRejectRate;
        private System.Windows.Forms.Label lblEfficiency;
        private System.Windows.Forms.Label lblReject;
        private System.Windows.Forms.Label lblProduced;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblPacketLost;
        private System.Windows.Forms.Label lblTotalAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Button btnMotorBaslat;
        private System.Windows.Forms.Button btnYenidenBaslat;
        private System.Windows.Forms.Button btnSqlTest;
    }
}

