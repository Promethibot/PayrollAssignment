Public Class frmPay

    Const _cdecFica As Decimal = 0.0765D
    Const _cdecFed As Decimal = 0.22D
    Const _cdecState As Decimal = 0.04D

    Dim strIncome As String
    Dim decIncome As Decimal
    Dim decFica As Decimal
    Dim decFederal As Decimal
    Dim decState As Decimal
    Dim decNet As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub tbxInput_TextChanged(sender As Object, e As EventArgs) Handles tbxInput.TextChanged
        If tbxInput.TextLength > 0 Then
            btnTaxCalc.Enabled = True
            btnClear.Enabled = True
            strIncome = tbxInput.Text
        End If
        If tbxInput.TextLength = 0 Then
            btnTaxCalc.Enabled = False
        End If

        AutoSize = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxInput.Text = ""
        lblFiCalc.Text = ""
        lblFedCalc.Text = ""
        lblStateCalc.Text = ""
        lblFinal.Text = ""
        lblError.Visible = False
        btnClear.Enabled = False
        tbxInput.Select()
    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        If Decimal.TryParse(strIncome, decIncome) Then
            lblError.Visible = False
            decFica = _cdecFica * decIncome
            decFederal = _cdecFed * decIncome
            decState = _cdecState * decIncome
            decNet = (decIncome - (decFica + decFederal + decState))

            lblFiCalc.Text = "$" + (decFica).ToString("N2")
            lblFedCalc.Text = "$" + (decFederal).ToString("N2")
            lblStateCalc.Text = "$" + (decState).ToString("N2")
            lblFinal.Text = "$" + (decNet).ToString("N2")
            btnClear.Enabled = True
        Else
            lblFiCalc.Text = ""
            lblFedCalc.Text = ""
            lblStateCalc.Text = ""
            lblFinal.Text = ""
            lblError.Visible = True
        End If
    End Sub

    Private Sub frmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxInput.Select()
    End Sub
End Class
