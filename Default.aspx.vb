
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtb_hours.TextChanged

    End Sub

    Protected Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        ' Clear out textboxes and results label
        txtb_wage.Text = String.Empty
        txtb_hours.Text = String.Empty
        txtb_pretax.Text = String.Empty
        txtb_aftertax.Text = String.Empty
        lbl_results.Text = String.Empty



    End Sub
End Class
