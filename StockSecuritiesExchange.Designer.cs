﻿namespace StockMarketApplication
{
    partial class StockSecuritiesExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSecuritiesExchange));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketDepthByOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketDepthByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeBidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginTradingToolStripMenuItem,
            this.stopTradingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.marketToolStripMenuItem.Text = "Market <<Closed>>";
            // 
            // beginTradingToolStripMenuItem
            // 
            this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
            this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beginTradingToolStripMenuItem.Text = "Begin Trading";
            this.beginTradingToolStripMenuItem.Click += new System.EventHandler(this.beginTradingToolStripMenuItem_Click);
            // 
            // stopTradingToolStripMenuItem
            // 
            this.stopTradingToolStripMenuItem.Name = "stopTradingToolStripMenuItem";
            this.stopTradingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopTradingToolStripMenuItem.Text = "Stop Trading";
            this.stopTradingToolStripMenuItem.Click += new System.EventHandler(this.stopTradingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketDepthByOrderToolStripMenuItem,
            this.marketDepthByPriceToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.watchToolStripMenuItem.Text = "Watch";
            // 
            // stockStateSummaryToolStripMenuItem
            // 
            this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
            this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.stockStateSummaryToolStripMenuItem.Text = "Stock State Summary";
            this.stockStateSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockStateSummaryToolStripMenuItem_Click);
            // 
            // marketDepthByOrderToolStripMenuItem
            // 
            this.marketDepthByOrderToolStripMenuItem.Name = "marketDepthByOrderToolStripMenuItem";
            this.marketDepthByOrderToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marketDepthByOrderToolStripMenuItem.Text = "Market Depth by Order";
            // 
            // marketDepthByPriceToolStripMenuItem
            // 
            this.marketDepthByPriceToolStripMenuItem.Name = "marketDepthByPriceToolStripMenuItem";
            this.marketDepthByPriceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marketDepthByPriceToolStripMenuItem.Text = "Market Depth by Price";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeBidToolStripMenuItem,
            this.askToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // placeBidToolStripMenuItem
            // 
            this.placeBidToolStripMenuItem.Name = "placeBidToolStripMenuItem";
            this.placeBidToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.placeBidToolStripMenuItem.Text = "Bid";
            this.placeBidToolStripMenuItem.Click += new System.EventHandler(this.placeBidToolStripMenuItem_Click);
            // 
            // askToolStripMenuItem
            // 
            this.askToolStripMenuItem.Name = "askToolStripMenuItem";
            this.askToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.askToolStripMenuItem.Text = "Ask";
            this.askToolStripMenuItem.Click += new System.EventHandler(this.askToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalTileToolStripMenuItem,
            this.verticalTileToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalTileToolStripMenuItem
            // 
            this.horizontalTileToolStripMenuItem.Name = "horizontalTileToolStripMenuItem";
            this.horizontalTileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.horizontalTileToolStripMenuItem.Text = "Horizontal Tile";
            this.horizontalTileToolStripMenuItem.Click += new System.EventHandler(this.horizontalTileToolStripMenuItem_Click);
            // 
            // verticalTileToolStripMenuItem
            // 
            this.verticalTileToolStripMenuItem.Name = "verticalTileToolStripMenuItem";
            this.verticalTileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.verticalTileToolStripMenuItem.Text = "Vertical Tile";
            this.verticalTileToolStripMenuItem.Click += new System.EventHandler(this.verticalTileToolStripMenuItem_Click);
            // 
            // StockSecuritiesExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 277);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockSecuritiesExchange";
            this.Text = "Stock Securities Exchange";
            this.Load += new System.EventHandler(this.StockSecuritiesExchange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeBidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockStateSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketDepthByOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketDepthByPriceToolStripMenuItem;
    }
}