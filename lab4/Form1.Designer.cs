namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.calculatingButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rublesLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.rublesCounterLabel = new System.Windows.Forms.Label();
            this.currencyCounterLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.currencyPriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exchangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 165);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(12, 30);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(88, 20);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Initial price:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(106, 30);
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceNumericUpDown.TabIndex = 2;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(106, 61);
            this.daysNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.daysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.daysNumericUpDown.TabIndex = 4;
            this.daysNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.daysNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysLabel.Location = new System.Drawing.Point(12, 61);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(49, 20);
            this.daysLabel.TabIndex = 3;
            this.daysLabel.Text = "Days:";
            // 
            // calculatingButton
            // 
            this.calculatingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatingButton.Location = new System.Drawing.Point(16, 110);
            this.calculatingButton.Name = "calculatingButton";
            this.calculatingButton.Size = new System.Drawing.Size(75, 23);
            this.calculatingButton.TabIndex = 5;
            this.calculatingButton.Text = "Start";
            this.calculatingButton.UseVisualStyleBackColor = true;
            this.calculatingButton.Click += new System.EventHandler(this.calculatingButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rublesLabel
            // 
            this.rublesLabel.AutoSize = true;
            this.rublesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rublesLabel.Location = new System.Drawing.Point(57, 17);
            this.rublesLabel.Name = "rublesLabel";
            this.rublesLabel.Size = new System.Drawing.Size(63, 20);
            this.rublesLabel.TabIndex = 6;
            this.rublesLabel.Text = "Rubles:";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyLabel.Location = new System.Drawing.Point(186, 17);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(76, 20);
            this.currencyLabel.TabIndex = 7;
            this.currencyLabel.Text = "Currency:";
            // 
            // rublesCounterLabel
            // 
            this.rublesCounterLabel.AutoSize = true;
            this.rublesCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rublesCounterLabel.Location = new System.Drawing.Point(44, 48);
            this.rublesCounterLabel.Name = "rublesCounterLabel";
            this.rublesCounterLabel.Size = new System.Drawing.Size(76, 20);
            this.rublesCounterLabel.TabIndex = 8;
            this.rublesCounterLabel.Text = "100,0000";
            // 
            // currencyCounterLabel
            // 
            this.currencyCounterLabel.AutoSize = true;
            this.currencyCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyCounterLabel.Location = new System.Drawing.Point(226, 45);
            this.currencyCounterLabel.Name = "currencyCounterLabel";
            this.currencyCounterLabel.Size = new System.Drawing.Size(36, 20);
            this.currencyCounterLabel.TabIndex = 9;
            this.currencyCounterLabel.Text = "100";
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buyButton.Location = new System.Drawing.Point(584, 61);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 10;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellButton.Location = new System.Drawing.Point(704, 61);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 11;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // currencyPriceLabel
            // 
            this.currencyPriceLabel.AutoSize = true;
            this.currencyPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyPriceLabel.Location = new System.Drawing.Point(247, 110);
            this.currencyPriceLabel.Name = "currencyPriceLabel";
            this.currencyPriceLabel.Size = new System.Drawing.Size(176, 20);
            this.currencyPriceLabel.TabIndex = 12;
            this.currencyPriceLabel.Text = "Currency price: 50,0000";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.currencyLabel);
            this.panel1.Controls.Add(this.rublesLabel);
            this.panel1.Controls.Add(this.rublesCounterLabel);
            this.panel1.Controls.Add(this.currencyCounterLabel);
            this.panel1.Location = new System.Drawing.Point(251, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 85);
            this.panel1.TabIndex = 13;
            // 
            // exchangeNumericUpDown
            // 
            this.exchangeNumericUpDown.Location = new System.Drawing.Point(584, 30);
            this.exchangeNumericUpDown.Name = "exchangeNumericUpDown";
            this.exchangeNumericUpDown.Size = new System.Drawing.Size(195, 20);
            this.exchangeNumericUpDown.TabIndex = 14;
            this.exchangeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exchangeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.exchangeNumericUpDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currencyPriceLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.calculatingButton);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button calculatingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label rublesLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label rublesCounterLabel;
        private System.Windows.Forms.Label currencyCounterLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label currencyPriceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown exchangeNumericUpDown;
    }
}

