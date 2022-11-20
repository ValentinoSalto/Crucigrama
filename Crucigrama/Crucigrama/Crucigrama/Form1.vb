Public Class Form1
    Dim PEPSI As String
    Dim GUARANA As String
    Dim MIRINDA As String
    Dim GIN As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PEPSI = "PEPSI"
        GUARANA = "GUARANA"
        MIRINDA = "MIRINDA"
        GIN = "GIN"
        If PEPSI = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text Then
            CheckBox1.Checked = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        Else
            CheckBox1.Checked = False
        End If

        If GUARANA = TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox9.Text + TextBox17.Text Then
            CheckBox2.Checked = True
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
            TextBox15.Enabled = False
            TextBox16.Enabled = False
            TextBox9.Enabled = False
            TextBox17.Enabled = False
        Else
            CheckBox2.Checked = False
        End If
        If GIN = TextBox12.Text + TextBox18.Text + TextBox19.Text Then
            CheckBox3.Checked = True
            TextBox12.Enabled = False
            TextBox18.Enabled = False
            TextBox19.Enabled = False
        Else
            CheckBox3.Checked = False
        End If
        If MIRINDA = TextBox6.Text + TextBox5.Text + TextBox7.Text + TextBox8.Text + TextBox9.Text + TextBox10.Text + TextBox11.Text Then
            CheckBox4.Checked = True
            TextBox6.Enabled = False
            TextBox5.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
        Else
            CheckBox4.Checked = False
        End If








    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
