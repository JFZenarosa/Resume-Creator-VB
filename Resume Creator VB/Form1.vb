Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form1
    Private Sub create_button_Click(sender As Object, e As EventArgs) Handles create_button.Click
        Dim jsonpath As String = "X:\School\Visual Studio\Repository\Resume Creator VB\Resume Creator VB\resumeCreator.json"
        Dim openfile As String = File.ReadAllText(jsonpath)
        Dim resumeout As JsonReader = JsonConvert.DeserializeObject(Of JsonReader)(openfile)
        Dim pdfcreator As Document = New Document()
        PdfWriter.GetInstance(pdfcreator, New FileStream("X:\School\Visual Studio\Repository\Resume Creator VB\Resume Creator VB\ZENAROSA_JAIREH.pdf", FileMode.Create))
        Dim font1 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.COURIER.ToString(), 25, iTextSharp.text.Font.BOLD)
        Dim font2 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.COURIER.ToString(), 17, iTextSharp.text.Font.BOLD)
        Dim font3 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13)
        Dim font4 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13, iTextSharp.text.Font.BOLD)
        Dim font5 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 8)
        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(resumeout.Image)
        image.ScalePercent(27.0F)
        image.Alignment = 6
        Dim horiLine As LineSeparator = New LineSeparator(4.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim fullname As Paragraph = New Paragraph(resumeout.Full_Name & vbLf, font1)
        Dim homeAddress As Paragraph = New Paragraph(vbLf & resumeout.Home_Address)
        Dim emailAddress As Paragraph = New Paragraph(resumeout.Email_Address)
        Dim contactNum As Paragraph = New Paragraph(resumeout.Contact_num)
        Dim birthdate As Paragraph = New Paragraph(resumeout.Birthdate & vbLf & vbLf)
        Dim objectiveHeader As Paragraph = New Paragraph(resumeout.objective_Header & vbLf & vbLf, font2)
        Dim objective As Paragraph = New Paragraph("      " & resumeout.Objective & vbLf & vbLf)
        Dim educHeader As Paragraph = New Paragraph(resumeout.Educ_Header & vbLf & vbLf, font2)
        Dim cyear As Phrase = New Phrase("     " & resumeout.Cyear, font3)
        Dim college As Phrase = New Phrase("          College                   " & resumeout.College & vbLf & vbLf, font3)
        Dim hsyear As Phrase = New Phrase("     " & resumeout.HSyear, font3)
        Dim highschool As Phrase = New Phrase("          Highschool             " & resumeout.Highschool & vbLf & vbLf, font3)
        Dim eyear As Phrase = New Phrase("     " & resumeout.Eyear, font3)
        Dim elementary As Phrase = New Phrase("          Elementary             " & resumeout.Elementary & vbLf & vbLf, font3)
        Dim strHeader As Paragraph = New Paragraph(resumeout.Str_Header & vbLf & vbLf, font2)
        Dim str1 As Paragraph = New Paragraph(vbLf & "        • " & resumeout.Str1 & vbLf & vbLf, font4)
        Dim str2 As Paragraph = New Paragraph("        • " & resumeout.Str2 & vbLf & vbLf, font4)
        Dim str3 As Paragraph = New Paragraph("        • " & resumeout.Str3 & vbLf & vbLf, font4)
        Dim str4 As Paragraph = New Paragraph("        • " & resumeout.Str4 & vbLf & vbLf & vbLf & vbLf & vbLf, font4)
        Dim wknHeader As Paragraph = New Paragraph(resumeout.Wkn_Header & vbLf & vbLf, font2)
        Dim wkn1 As Paragraph = New Paragraph(vbLf & "        • " & resumeout.Wkn1 & vbLf & vbLf, font4)
        Dim wkn2 As Paragraph = New Paragraph("        • " & resumeout.Wkn2 & vbLf & vbLf, font4)
        Dim wkn3 As Paragraph = New Paragraph("        • " & resumeout.Wkn3 & vbLf & vbLf, font4)
        Dim wkn4 As Paragraph = New Paragraph("        • " & resumeout.Wkn4 & vbLf & vbLf, font4)
        Dim expHeader As Paragraph = New Paragraph(resumeout.Exp_Header & vbLf & vbLf, font2)
        Dim exp1 As Paragraph = New Paragraph("        • " & resumeout.Exp1, font4)
        Dim exp2 As Paragraph = New Paragraph("        • " & resumeout.Exp2, font4)
        Dim exp3 As Paragraph = New Paragraph("        • " & resumeout.Exp3, font4)
        Dim exp4 As Paragraph = New Paragraph("        • " & resumeout.Exp4 & vbLf & vbLf & vbLf & vbLf & vbLf, font4)
        Dim footer As Paragraph = New Paragraph(resumeout.Footer, font5)
        footer.Alignment = Element.ALIGN_CENTER
        pdfcreator.Open()
        pdfcreator.Add(image)
        pdfcreator.Add(fullname)
        pdfcreator.Add(homeAddress)
        pdfcreator.Add(emailAddress)
        pdfcreator.Add(contactNum)
        pdfcreator.Add(birthdate)
        pdfcreator.Add(objectiveHeader)
        pdfcreator.Add(horiLine)
        pdfcreator.Add(objective)
        pdfcreator.Add(educHeader)
        pdfcreator.Add(horiLine)
        pdfcreator.Add(cyear)
        pdfcreator.Add(college)
        pdfcreator.Add(hsyear)
        pdfcreator.Add(highschool)
        pdfcreator.Add(eyear)
        pdfcreator.Add(elementary)
        pdfcreator.Add(strHeader)
        pdfcreator.Add(horiLine)
        pdfcreator.Add(str1)
        pdfcreator.Add(str2)
        pdfcreator.Add(str3)
        pdfcreator.Add(str4)
        pdfcreator.Add(wknHeader)
        pdfcreator.Add(horiLine)
        pdfcreator.Add(wkn1)
        pdfcreator.Add(wkn2)
        pdfcreator.Add(wkn3)
        pdfcreator.Add(expHeader)
        pdfcreator.Add(horiLine)
        pdfcreator.Add(exp1)
        pdfcreator.Add(exp2)
        pdfcreator.Add(exp3)
        pdfcreator.Add(exp4)
        pdfcreator.Add(footer)
        pdfcreator.Close()
    End Sub

    Public Class jsonreader
        Public Property Image As String
        Public Property Full_Name As String
        Public Property Home_Address As String
        Public Property Birthdate As String
        Public Property Email_Address As String
        Public Property Contact_num As String
        Public Property objective_Header As String
        Public Property Objective As String
        Public Property Educ_Header As String
        Public Property College As String
        Public Property Cyear As String
        Public Property Highschool As String
        Public Property HSyear As String
        Public Property Elementary As String
        Public Property Eyear As String
        Public Property Str_Header As String
        Public Property Str1 As String
        Public Property Str2 As String
        Public Property Str3 As String
        Public Property Str4 As String
        Public Property Wkn_Header As String
        Public Property Wkn1 As String
        Public Property Wkn2 As String
        Public Property Wkn3 As String
        Public Property Wkn4 As String
        Public Property Exp_Header As String
        Public Property Exp1 As String
        Public Property Exp2 As String
        Public Property Exp3 As String
        Public Property Exp4 As String
        Public Property Footer As String
    End Class
End Class
