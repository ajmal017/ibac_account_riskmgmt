﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbErrorAndLog = New System.Windows.Forms.ListBox()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.chtEquity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbData = New System.Windows.Forms.ListBox()
        Me.dsAccountBalance = New System.Data.DataSet()
        Me.AccountNetLiq = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnStartAccSummary = New System.Windows.Forms.Button()
        Me.tmrCollectAccSummary = New System.Windows.Forms.Timer(Me.components)
        Me.btnAccUpdate = New System.Windows.Forms.Button()
        Me.tmrAccUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnIntradayChart = New System.Windows.Forms.Button()
        Me.cbDaysinchart = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnterOrder = New System.Windows.Forms.Button()
        Me.btnStartDate = New System.Windows.Forms.Button()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.btnEndDate = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnOpenChart = New System.Windows.Forms.Button()
        Me.btnDailyChart = New System.Windows.Forms.Button()
        Me.chtPctEquity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblStartingEquity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDayPct = New System.Windows.Forms.Label()
        Me.dgPercent = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxTws1 = New AxTWSLib.AxTws()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAccountNum = New System.Windows.Forms.Label()
        Me.lblServerTime = New System.Windows.Forms.Label()
        Me.tmrServerTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.chtEquity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsAccountBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNetLiq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtPctEquity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbErrorAndLog
        '
        Me.lbErrorAndLog.FormattingEnabled = True
        Me.lbErrorAndLog.HorizontalScrollbar = True
        Me.lbErrorAndLog.Location = New System.Drawing.Point(12, 586)
        Me.lbErrorAndLog.Name = "lbErrorAndLog"
        Me.lbErrorAndLog.Size = New System.Drawing.Size(422, 95)
        Me.lbErrorAndLog.TabIndex = 1
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.Location = New System.Drawing.Point(309, 38)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(189, 24)
        Me.lblConnected.TabIndex = 2
        Me.lblConnected.Text = "NOT CONNECTED"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 33)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(116, 29)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect to IB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(154, 33)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(115, 30)
        Me.btnDisconnect.TabIndex = 4
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'chtEquity
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtEquity.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.chtEquity.Legends.Add(Legend1)
        Me.chtEquity.Location = New System.Drawing.Point(0, 127)
        Me.chtEquity.Name = "chtEquity"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtEquity.Series.Add(Series1)
        Me.chtEquity.Size = New System.Drawing.Size(744, 382)
        Me.chtEquity.TabIndex = 5
        Me.chtEquity.Text = "Chart1"
        '
        'lbData
        '
        Me.lbData.FormattingEnabled = True
        Me.lbData.Location = New System.Drawing.Point(448, 586)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(258, 95)
        Me.lbData.TabIndex = 6
        '
        'dsAccountBalance
        '
        Me.dsAccountBalance.DataSetName = "NewDataSet"
        Me.dsAccountBalance.Tables.AddRange(New System.Data.DataTable() {Me.AccountNetLiq})
        '
        'AccountNetLiq
        '
        Me.AccountNetLiq.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.AccountNetLiq.TableName = "AccountNetLiq"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Date"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Time"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "NetLiq"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1117, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(164, 51)
        Me.DataGridView1.TabIndex = 7
        Me.DataGridView1.Visible = False
        '
        'btnStartAccSummary
        '
        Me.btnStartAccSummary.Location = New System.Drawing.Point(893, 88)
        Me.btnStartAccSummary.Name = "btnStartAccSummary"
        Me.btnStartAccSummary.Size = New System.Drawing.Size(122, 30)
        Me.btnStartAccSummary.TabIndex = 8
        Me.btnStartAccSummary.Text = "Start Acc Summary"
        Me.btnStartAccSummary.UseVisualStyleBackColor = True
        '
        'tmrCollectAccSummary
        '
        Me.tmrCollectAccSummary.Interval = 5000
        '
        'btnAccUpdate
        '
        Me.btnAccUpdate.Location = New System.Drawing.Point(1057, 548)
        Me.btnAccUpdate.Name = "btnAccUpdate"
        Me.btnAccUpdate.Size = New System.Drawing.Size(111, 29)
        Me.btnAccUpdate.TabIndex = 9
        Me.btnAccUpdate.Text = "Start Acc Update"
        Me.btnAccUpdate.UseVisualStyleBackColor = True
        Me.btnAccUpdate.Visible = False
        '
        'tmrAccUpdate
        '
        Me.tmrAccUpdate.Interval = 5000
        '
        'btnIntradayChart
        '
        Me.btnIntradayChart.Location = New System.Drawing.Point(1073, 597)
        Me.btnIntradayChart.Name = "btnIntradayChart"
        Me.btnIntradayChart.Size = New System.Drawing.Size(86, 23)
        Me.btnIntradayChart.TabIndex = 10
        Me.btnIntradayChart.Text = "IntraDay Chart"
        Me.btnIntradayChart.UseVisualStyleBackColor = True
        Me.btnIntradayChart.Visible = False
        '
        'cbDaysinchart
        '
        Me.cbDaysinchart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDaysinchart.FormattingEnabled = True
        Me.cbDaysinchart.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbDaysinchart.Location = New System.Drawing.Point(1021, 88)
        Me.cbDaysinchart.Name = "cbDaysinchart"
        Me.cbDaysinchart.Size = New System.Drawing.Size(121, 21)
        Me.cbDaysinchart.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1018, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Days in Chart"
        '
        'btnEnterOrder
        '
        Me.btnEnterOrder.Location = New System.Drawing.Point(1084, 515)
        Me.btnEnterOrder.Name = "btnEnterOrder"
        Me.btnEnterOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterOrder.TabIndex = 13
        Me.btnEnterOrder.Text = "Button2"
        Me.btnEnterOrder.UseVisualStyleBackColor = True
        Me.btnEnterOrder.Visible = False
        '
        'btnStartDate
        '
        Me.btnStartDate.Location = New System.Drawing.Point(763, 613)
        Me.btnStartDate.Name = "btnStartDate"
        Me.btnStartDate.Size = New System.Drawing.Size(85, 23)
        Me.btnStartDate.TabIndex = 14
        Me.btnStartDate.Text = "Start Date"
        Me.btnStartDate.UseVisualStyleBackColor = True
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(762, 586)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(85, 20)
        Me.txtStartDate.TabIndex = 15
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(868, 587)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(86, 20)
        Me.txtEndDate.TabIndex = 16
        '
        'btnEndDate
        '
        Me.btnEndDate.Location = New System.Drawing.Point(869, 613)
        Me.btnEndDate.Name = "btnEndDate"
        Me.btnEndDate.Size = New System.Drawing.Size(86, 23)
        Me.btnEndDate.TabIndex = 17
        Me.btnEndDate.Text = "End Date"
        Me.btnEndDate.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1182, 693)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(742, 574)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(225, 104)
        '
        'btnOpenChart
        '
        Me.btnOpenChart.Location = New System.Drawing.Point(762, 643)
        Me.btnOpenChart.Name = "btnOpenChart"
        Me.btnOpenChart.Size = New System.Drawing.Size(86, 23)
        Me.btnOpenChart.TabIndex = 19
        Me.btnOpenChart.Text = "Intraday Chart"
        Me.btnOpenChart.UseVisualStyleBackColor = True
        '
        'btnDailyChart
        '
        Me.btnDailyChart.Location = New System.Drawing.Point(869, 643)
        Me.btnDailyChart.Name = "btnDailyChart"
        Me.btnDailyChart.Size = New System.Drawing.Size(85, 23)
        Me.btnDailyChart.TabIndex = 20
        Me.btnDailyChart.Text = "Daily Chart"
        Me.btnDailyChart.UseVisualStyleBackColor = True
        '
        'chtPctEquity
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtPctEquity.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.chtPctEquity.Legends.Add(Legend2)
        Me.chtPctEquity.Location = New System.Drawing.Point(774, 137)
        Me.chtPctEquity.Name = "chtPctEquity"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtPctEquity.Series.Add(Series2)
        Me.chtPctEquity.Size = New System.Drawing.Size(346, 343)
        Me.chtPctEquity.TabIndex = 21
        Me.chtPctEquity.Text = "Percent Equity"
        '
        'lblStartingEquity
        '
        Me.lblStartingEquity.AutoSize = True
        Me.lblStartingEquity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingEquity.Location = New System.Drawing.Point(788, 17)
        Me.lblStartingEquity.Name = "lblStartingEquity"
        Me.lblStartingEquity.Size = New System.Drawing.Size(19, 20)
        Me.lblStartingEquity.TabIndex = 22
        Me.lblStartingEquity.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(564, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "STARTING EQUITY $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "DAY P&&L "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(857, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "%"
        '
        'lblDayPct
        '
        Me.lblDayPct.AutoSize = True
        Me.lblDayPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayPct.Location = New System.Drawing.Point(788, 36)
        Me.lblDayPct.Name = "lblDayPct"
        Me.lblDayPct.Size = New System.Drawing.Size(19, 20)
        Me.lblDayPct.TabIndex = 26
        Me.lblDayPct.Text = "0"
        '
        'dgPercent
        '
        Me.dgPercent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPercent.Location = New System.Drawing.Point(1057, 12)
        Me.dgPercent.Name = "dgPercent"
        Me.dgPercent.Size = New System.Drawing.Size(121, 51)
        Me.dgPercent.TabIndex = 27
        Me.dgPercent.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSetting, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuSetting
        '
        Me.menuSetting.Name = "menuSetting"
        Me.menuSetting.Size = New System.Drawing.Size(56, 20)
        Me.menuSetting.Text = "Setting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AxTws1
        '
        Me.AxTws1.Enabled = True
        Me.AxTws1.Location = New System.Drawing.Point(999, 586)
        Me.AxTws1.Name = "AxTws1"
        Me.AxTws1.OcxState = CType(resources.GetObject("AxTws1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTws1.Size = New System.Drawing.Size(100, 50)
        Me.AxTws1.TabIndex = 29
        Me.AxTws1.Visible = False
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(12, 76)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(200, 31)
        Me.lblWarning.TabIndex = 30
        Me.lblWarning.Text = "Label Warning"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(568, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Account:"
        '
        'lblAccountNum
        '
        Me.lblAccountNum.AutoSize = True
        Me.lblAccountNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNum.Location = New System.Drawing.Point(789, 60)
        Me.lblAccountNum.Name = "lblAccountNum"
        Me.lblAccountNum.Size = New System.Drawing.Size(45, 13)
        Me.lblAccountNum.TabIndex = 32
        Me.lblAccountNum.Text = "Label6"
        '
        'lblServerTime
        '
        Me.lblServerTime.AutoSize = True
        Me.lblServerTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerTime.Location = New System.Drawing.Point(789, 88)
        Me.lblServerTime.Name = "lblServerTime"
        Me.lblServerTime.Size = New System.Drawing.Size(0, 13)
        Me.lblServerTime.TabIndex = 33
        '
        'tmrServerTime
        '
        Me.tmrServerTime.Interval = 900
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 693)
        Me.Controls.Add(Me.lblServerTime)
        Me.Controls.Add(Me.lblAccountNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.AxTws1)
        Me.Controls.Add(Me.dgPercent)
        Me.Controls.Add(Me.lblDayPct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStartingEquity)
        Me.Controls.Add(Me.chtPctEquity)
        Me.Controls.Add(Me.btnDailyChart)
        Me.Controls.Add(Me.btnOpenChart)
        Me.Controls.Add(Me.btnEndDate)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.btnStartDate)
        Me.Controls.Add(Me.btnEnterOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDaysinchart)
        Me.Controls.Add(Me.btnIntradayChart)
        Me.Controls.Add(Me.btnAccUpdate)
        Me.Controls.Add(Me.btnStartAccSummary)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.chtEquity)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblConnected)
        Me.Controls.Add(Me.lbErrorAndLog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IBac - IB Account Risk Management"
        CType(Me.chtEquity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsAccountBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNetLiq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtPctEquity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbErrorAndLog As System.Windows.Forms.ListBox
    Friend WithEvents lblConnected As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents chtEquity As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lbData As System.Windows.Forms.ListBox
    Friend WithEvents dsAccountBalance As System.Data.DataSet
    Friend WithEvents AccountNetLiq As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnStartAccSummary As System.Windows.Forms.Button
    Friend WithEvents tmrCollectAccSummary As System.Windows.Forms.Timer
    Friend WithEvents btnAccUpdate As System.Windows.Forms.Button
    Friend WithEvents tmrAccUpdate As System.Windows.Forms.Timer
    Friend WithEvents btnIntradayChart As System.Windows.Forms.Button
    Friend WithEvents cbDaysinchart As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnterOrder As System.Windows.Forms.Button
    Friend WithEvents btnStartDate As System.Windows.Forms.Button
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents btnEndDate As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnOpenChart As System.Windows.Forms.Button
    Friend WithEvents btnDailyChart As System.Windows.Forms.Button
    Friend WithEvents chtPctEquity As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblStartingEquity As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDayPct As System.Windows.Forms.Label
    Friend WithEvents dgPercent As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AxTws1 As AxTWSLib.AxTws
    Friend WithEvents menuSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAccountNum As System.Windows.Forms.Label
    Friend WithEvents lblServerTime As System.Windows.Forms.Label
    Friend WithEvents tmrServerTime As System.Windows.Forms.Timer

End Class
