
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        ' Clear out textboxes and results label
        txtb_wage.Text = String.Empty
        txtb_hours.Text = String.Empty
        txtb_pretax.Text = String.Empty
        txtb_aftertax.Text = String.Empty
        lbl_results.Text = String.Empty



    End Sub

    Protected Sub btn_caculate_Click(sender As Object, e As EventArgs) Handles btn_caculate.Click
        ' clear out any prior result
        lbl_results.Text = String.Empty

        ' Verify user data is valid
        If Val(txtb_wage.Text) <= 0 Then
            txtb_wage.Text = String.Empty
            lbl_results.Text = "Please enter valid wage amount."
            Exit Sub

        End If

        If Val(txtb_hours.Text) <= 0 Then
            txtb_hours.Text = String.Empty
            lbl_results.Text = "Please enter valid hours amount."
            Exit Sub
        End If

        ' assign variables
        Dim wage As Decimal = txtb_wage.Text
        Dim hours As Decimal = txtb_hours.Text
        Dim pretax As Decimal = Val(txtb_pretax.Text)
        Dim after As Decimal = Val(txtb_aftertax.Text)
        Dim result As Decimal
        Dim taxes As Decimal

        ' compute gross pay
        result = (wage * hours) - pretax

        ' compute taxes
        If result >= 500 Then
            taxes = result * 0.22
        Else
            taxes = result * 0.18
        End If

        ' caculate net pay
        result -= (taxes + after)

        ' display net pay
        lbl_results.Text = "Your net pay for this week is " & String.Format("{0:C}", result)

    End Sub
End Class
