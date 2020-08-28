namespace SelleFruit
{
    partial class SelleFruit
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
            Janus.Windows.GridEX.GridEXLayout GridStore_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelleFruit));
            Janus.Windows.GridEX.GridEXLayout GridSeller_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout GridBuy_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout GridRep_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStore = new Janus.Windows.EditControls.UIButton();
            this.GridStore = new Janus.Windows.GridEX.GridEX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeller = new Janus.Windows.EditControls.UIButton();
            this.GridSeller = new Janus.Windows.GridEX.GridEX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridBuy = new Janus.Windows.GridEX.GridEX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridRep = new Janus.Windows.GridEX.GridEX();
            this.bkwSeller = new System.ComponentModel.BackgroundWorker();
            this.bkwStore = new System.ComponentModel.BackgroundWorker();
            this.bkwBuy = new System.ComponentModel.BackgroundWorker();
            this.bkwRep = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStore)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeller)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBuy)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStore);
            this.groupBox1.Controls.Add(this.GridStore);
            this.groupBox1.Location = new System.Drawing.Point(219, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(275, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انبار اولیه";
            // 
            // btnStore
            // 
            this.btnStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStore.Location = new System.Drawing.Point(3, 252);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(266, 23);
            this.btnStore.TabIndex = 19;
            this.btnStore.Text = "موجودی انبار اولیه";
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // GridStore
            // 
            this.GridStore.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridStore.AlternatingColors = true;
            GridStore_DesignTimeLayout.LayoutString = resources.GetString("GridStore_DesignTimeLayout.LayoutString");
            this.GridStore.DesignTimeLayout = GridStore_DesignTimeLayout;
            this.GridStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridStore.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.GridStore.GroupByBoxVisible = false;
            this.GridStore.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.GridStore.Location = new System.Drawing.Point(3, 17);
            this.GridStore.Name = "GridStore";
            this.GridStore.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.GridStore.ScrollBarWidth = 15;
            this.GridStore.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.GridStore.Size = new System.Drawing.Size(269, 230);
            this.GridStore.TabIndex = 18;
            this.GridStore.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridStore.UseCompatibleTextRendering = true;
            this.GridStore.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeller);
            this.groupBox2.Controls.Add(this.GridSeller);
            this.groupBox2.Location = new System.Drawing.Point(500, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(274, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فروشندگان میوه";
            // 
            // btnSeller
            // 
            this.btnSeller.ActiveFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.btnSeller.ActiveFormatStyle.BackColorGradient = System.Drawing.Color.WhiteSmoke;
            this.btnSeller.ActiveFormatStyle.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeller.FlatBorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSeller.Location = new System.Drawing.Point(3, 252);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(265, 23);
            this.btnSeller.TabIndex = 20;
            this.btnSeller.Text = "موجودی فروشندگان میوه";
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // GridSeller
            // 
            this.GridSeller.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridSeller.AlternatingColors = true;
            GridSeller_DesignTimeLayout.LayoutString = resources.GetString("GridSeller_DesignTimeLayout.LayoutString");
            this.GridSeller.DesignTimeLayout = GridSeller_DesignTimeLayout;
            this.GridSeller.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridSeller.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.GridSeller.GroupByBoxVisible = false;
            this.GridSeller.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.GridSeller.Location = new System.Drawing.Point(3, 17);
            this.GridSeller.Name = "GridSeller";
            this.GridSeller.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.GridSeller.ScrollBarWidth = 15;
            this.GridSeller.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.GridSeller.Size = new System.Drawing.Size(268, 230);
            this.GridSeller.TabIndex = 19;
            this.GridSeller.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridSeller.UseCompatibleTextRendering = true;
            this.GridSeller.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridBuy);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(201, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "خریداران میوه";
            // 
            // GridBuy
            // 
            this.GridBuy.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridBuy.AlternatingColors = true;
            GridBuy_DesignTimeLayout.LayoutString = resources.GetString("GridBuy_DesignTimeLayout.LayoutString");
            this.GridBuy.DesignTimeLayout = GridBuy_DesignTimeLayout;
            this.GridBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBuy.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.GridBuy.GroupByBoxVisible = false;
            this.GridBuy.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.GridBuy.Location = new System.Drawing.Point(3, 17);
            this.GridBuy.Name = "GridBuy";
            this.GridBuy.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.GridBuy.ScrollBarWidth = 15;
            this.GridBuy.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.GridBuy.Size = new System.Drawing.Size(195, 255);
            this.GridBuy.TabIndex = 17;
            this.GridBuy.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridBuy.UseCompatibleTextRendering = true;
            this.GridBuy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.GridBuy.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.GridBuy_FormattingRow);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridRep);
            this.groupBox4.Location = new System.Drawing.Point(18, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(756, 274);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "گزارش وضعیت فروش";
            // 
            // GridRep
            // 
            this.GridRep.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridRep.AlternatingColors = true;
            GridRep_DesignTimeLayout.LayoutString = resources.GetString("GridRep_DesignTimeLayout.LayoutString");
            this.GridRep.DesignTimeLayout = GridRep_DesignTimeLayout;
            this.GridRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRep.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.GridRep.GroupByBoxVisible = false;
            this.GridRep.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.GridRep.Location = new System.Drawing.Point(3, 17);
            this.GridRep.Name = "GridRep";
            this.GridRep.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.GridRep.ScrollBarWidth = 15;
            this.GridRep.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.GridRep.Size = new System.Drawing.Size(750, 254);
            this.GridRep.TabIndex = 16;
            this.GridRep.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridRep.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridRep.UseCompatibleTextRendering = true;
            this.GridRep.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // bkwSeller
            // 
            this.bkwSeller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwSeller_DoWork);
            // 
            // bkwStore
            // 
            this.bkwStore.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwStore_DoWork);
            // 
            // bkwBuy
            // 
            this.bkwBuy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwBuy_DoWork);
            // 
            // bkwRep
            // 
            this.bkwRep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwRep_DoWork_1);
            // 
            // SelleFruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(789, 582);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SelleFruit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "میوه فروشی";
            this.Load += new System.EventHandler(this.SelleFruit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSeller)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBuy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public Janus.Windows.GridEX.GridEX GridRep;
        private Janus.Windows.EditControls.UIButton btnStore;
        public Janus.Windows.GridEX.GridEX GridStore;
        private Janus.Windows.EditControls.UIButton btnSeller;
        public Janus.Windows.GridEX.GridEX GridSeller;
        public Janus.Windows.GridEX.GridEX GridBuy;
        private System.ComponentModel.BackgroundWorker bkwSeller;
        private System.ComponentModel.BackgroundWorker bkwStore;
        private System.ComponentModel.BackgroundWorker bkwBuy;
        private System.ComponentModel.BackgroundWorker bkwRep;
    }
}

