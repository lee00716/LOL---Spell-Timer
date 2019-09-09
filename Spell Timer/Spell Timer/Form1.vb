Public Class Form1
    Inherits Form

    Dim Startbuttons As New List(Of Button)
    Dim droparray As New List(Of ComboBox)
    Dim LabelArray As New List(Of Label)
    Dim InsightArray As New List(Of CheckBox)
    Dim IonianArray As New List(Of CheckBox)
    Dim ResultArray As New List(Of Label)
    Dim spelltimearray As New List(Of TimeSpan)
    Dim spelltime1, spelltime2, spelltime3, spelltime4, spelltime5, spelltime6, spelltime7, spelltime8, spelltime9, spelltime10, spelltime11, spelltime12, spelltime13, spelltime14, spelltime15, spelltime16, spelltime17 As TimeSpan
    Dim Stopwatches As New List(Of Stopwatch) From {New Stopwatch}
    Dim Stopbuttons As New List(Of Button)
    Dim Rewindbuttons As New List(Of Button)
    Dim Timers As New List(Of Timer)
    Dim Spellpics As New List(Of PictureBox)

    Public Sub New()
        InitializeComponent()

        Spellpics.Add(PictureBox1)
        Spellpics.Add(PictureBox2)
        Spellpics.Add(PictureBox3)
        Spellpics.Add(PictureBox4)
        Spellpics.Add(PictureBox5)
        Spellpics.Add(PictureBox6)
        Spellpics.Add(PictureBox7)
        Spellpics.Add(PictureBox8)
        Spellpics.Add(PictureBox9)


        Timers.Add(Timer1)
        Timers.Add(Timer2)
        Timers.Add(Timer3)
        Timers.Add(Timer4)
        Timers.Add(Timer5)
        Timers.Add(Timer6)
        Timers.Add(Timer7)
        Timers.Add(Timer8)
        Timers.Add(Timer9)
        Timers.Add(Timer10)
        Timers.Add(Timer11)
        Timers.Add(Timer12)
        Timers.Add(Timer13)
        Timers.Add(Timer14)
        Timers.Add(Timer15)
        Timers.Add(Timer16)
        Timers.Add(Timer17)


        Startbuttons.Add(Startbutton1)
        Startbuttons.Add(Startbutton2)
        Startbuttons.Add(Startbutton3)
        Startbuttons.Add(Startbutton4)
        Startbuttons.Add(Startbutton5)
        Startbuttons.Add(Startbutton6)
        Startbuttons.Add(Startbutton7)
        Startbuttons.Add(Startbutton8)
        Startbuttons.Add(Startbutton9)
        Startbuttons.Add(Startbutton10)
        Startbuttons.Add(Startbutton11)
        Startbuttons.Add(Startbutton12)
        Startbuttons.Add(Startbutton13)
        Startbuttons.Add(Startbutton14)
        Startbuttons.Add(Startbutton15)
        Startbuttons.Add(Startbutton16)
        Startbuttons.Add(Startbutton17)

        Stopbuttons.Add(Stopbutton1)
        Stopbuttons.Add(Stopbutton2)
        Stopbuttons.Add(Stopbutton3)
        Stopbuttons.Add(Stopbutton4)
        Stopbuttons.Add(Stopbutton5)
        Stopbuttons.Add(Stopbutton6)
        Stopbuttons.Add(Stopbutton7)
        Stopbuttons.Add(Stopbutton8)
        Stopbuttons.Add(Stopbutton9)
        Stopbuttons.Add(Stopbutton10)
        Stopbuttons.Add(Stopbutton11)
        Stopbuttons.Add(Stopbutton12)
        Stopbuttons.Add(Stopbutton13)
        Stopbuttons.Add(Stopbutton14)
        Stopbuttons.Add(Stopbutton15)
        Stopbuttons.Add(Stopbutton16)
        Stopbuttons.Add(Stopbutton17)

        Rewindbuttons.Add(Rewindbutton1)
        Rewindbuttons.Add(Rewindbutton2)
        Rewindbuttons.Add(Rewindbutton3)
        Rewindbuttons.Add(Rewindbutton4)
        Rewindbuttons.Add(Rewindbutton5)
        Rewindbuttons.Add(Rewindbutton6)
        Rewindbuttons.Add(Rewindbutton7)
        Rewindbuttons.Add(Rewindbutton8)
        Rewindbuttons.Add(Rewindbutton9)
        Rewindbuttons.Add(Rewindbutton10)
        Rewindbuttons.Add(Rewindbutton11)
        Rewindbuttons.Add(Rewindbutton12)
        Rewindbuttons.Add(Rewindbutton13)
        Rewindbuttons.Add(Rewindbutton14)
        Rewindbuttons.Add(Rewindbutton15)
        Rewindbuttons.Add(Rewindbutton16)
        Rewindbuttons.Add(Rewindbutton17)



        For i As Integer = 0 To 16
            Startbuttons(i).Tag = i
        Next

        For j As Integer = 0 To 16
            Stopbuttons(j).Tag = j
        Next

        For k As Integer = 0 To 16
            Rewindbuttons(k).Tag = k
        Next

        For l As Integer = 0 To 16
            Timers(l).Tag = l
        Next


        For repeat As Integer = 1 To 17
            Stopwatches.Add(New Stopwatch)
        Next


        droparray.Add(Spellcombobox1)
        droparray.Add(Spellcombobox2)
        droparray.Add(Spellcombobox3)
        droparray.Add(Spellcombobox4)
        droparray.Add(Spellcombobox5)
        droparray.Add(Spellcombobox6)
        droparray.Add(Spellcombobox7)
        droparray.Add(Spellcombobox8)
        droparray.Add(Spellcombobox9)

        LabelArray.Add(spellnamelabel1)
        LabelArray.Add(spellnamelabel2)
        LabelArray.Add(spellnamelabel3)
        LabelArray.Add(spellnamelabel4)
        LabelArray.Add(spellnamelabel5)
        LabelArray.Add(spellnamelabel6)
        LabelArray.Add(spellnamelabel7)
        LabelArray.Add(spellnamelabel8)
        LabelArray.Add(spellnamelabel9)
        LabelArray.Add(spellnamelabel10)
        LabelArray.Add(spellnamelabel11)
        LabelArray.Add(spellnamelabel12)
        LabelArray.Add(spellnamelabel13)
        LabelArray.Add(spellnamelabel14)
        LabelArray.Add(spellnamelabel15)
        LabelArray.Add(spellnamelabel16)
        LabelArray.Add(spellnamelabel17)

        InsightArray.Add(Insightcheckbox1)
        InsightArray.Add(Insightcheckbox2)
        InsightArray.Add(Insightcheckbox3)
        InsightArray.Add(Insightcheckbox4)
        InsightArray.Add(Insightcheckbox5)
        InsightArray.Add(Insightcheckbox6)
        InsightArray.Add(Insightcheckbox7)
        InsightArray.Add(Insightcheckbox8)
        InsightArray.Add(Insightcheckbox9)

        IonianArray.Add(Ioniancheckbox1)
        IonianArray.Add(Ioniancheckbox2)
        IonianArray.Add(Ioniancheckbox3)
        IonianArray.Add(Ioniancheckbox4)
        IonianArray.Add(Ioniancheckbox5)
        IonianArray.Add(Ioniancheckbox6)
        IonianArray.Add(Ioniancheckbox7)
        IonianArray.Add(Ioniancheckbox8)
        IonianArray.Add(Ioniancheckbox9)

        ResultArray.Add(timerlabel1)
        ResultArray.Add(timerlabel2)
        ResultArray.Add(timerlabel3)
        ResultArray.Add(timerlabel4)
        ResultArray.Add(timerlabel5)
        ResultArray.Add(timerlabel6)
        ResultArray.Add(timerlabel7)
        ResultArray.Add(timerlabel8)
        ResultArray.Add(timerlabel9)
        ResultArray.Add(timerlabel10)
        ResultArray.Add(timerlabel11)
        ResultArray.Add(timerlabel12)
        ResultArray.Add(timerlabel13)
        ResultArray.Add(timerlabel14)
        ResultArray.Add(timerlabel15)
        ResultArray.Add(timerlabel16)
        ResultArray.Add(timerlabel17)

        spelltimearray.Add(spelltime1)
        spelltimearray.Add(spelltime2)
        spelltimearray.Add(spelltime3)
        spelltimearray.Add(spelltime4)
        spelltimearray.Add(spelltime5)
        spelltimearray.Add(spelltime6)
        spelltimearray.Add(spelltime7)
        spelltimearray.Add(spelltime8)
        spelltimearray.Add(spelltime9)
        spelltimearray.Add(spelltime10)
        spelltimearray.Add(spelltime11)
        spelltimearray.Add(spelltime12)
        spelltimearray.Add(spelltime13)
        spelltimearray.Add(spelltime14)
        spelltimearray.Add(spelltime15)
        spelltimearray.Add(spelltime16)
        spelltimearray.Add(spelltime17)



    End Sub


    Private Sub Insightcheckbox1_CheckedChanged(sender As Object, e As EventArgs) Handles Insightcheckbox1.CheckedChanged
        Insightcheckbox2.Checked = Insightcheckbox1.Checked
    End Sub

    Private Sub Insightcheckbox4_CheckedChanged(sender As Object, e As EventArgs) Handles Insightcheckbox4.CheckedChanged
        Insightcheckbox5.Checked = Insightcheckbox4.Checked
    End Sub

    Private Sub Insightcheckbox6_CheckedChanged(sender As Object, e As EventArgs) Handles Insightcheckbox6.CheckedChanged
        Insightcheckbox7.Checked = Insightcheckbox6.Checked
    End Sub

    Private Sub Insightcheckbox8_CheckedChanged(sender As Object, e As EventArgs) Handles Insightcheckbox8.CheckedChanged
        Insightcheckbox9.Checked = Insightcheckbox8.Checked
    End Sub

    Private Sub Ioniancheckbox1_CheckedChanged(sender As Object, e As EventArgs) Handles Ioniancheckbox1.CheckedChanged
        Ioniancheckbox2.Checked = Ioniancheckbox1.Checked
    End Sub

    Private Sub Ioniancheckbox4_CheckedChanged(sender As Object, e As EventArgs) Handles Ioniancheckbox4.CheckedChanged
        Ioniancheckbox5.Checked = Ioniancheckbox4.Checked
    End Sub

    Private Sub Ioniancheckbox6_CheckedChanged(sender As Object, e As EventArgs) Handles Ioniancheckbox6.CheckedChanged
        Ioniancheckbox7.Checked = Ioniancheckbox6.Checked
    End Sub

    Private Sub Ioniancheckbox8_CheckedChanged(sender As Object, e As EventArgs) Handles Ioniancheckbox8.CheckedChanged
        Ioniancheckbox9.Checked = Ioniancheckbox8.Checked
    End Sub

    Sub StopEventHandler(sender As Object, e As EventArgs) Handles Stopbutton1.Click, Stopbutton2.Click, Stopbutton3.Click, Stopbutton4.Click, Stopbutton5.Click, Stopbutton6.Click, Stopbutton7.Click, Stopbutton8.Click, Stopbutton9.Click, Stopbutton10.Click, Stopbutton11.Click, Stopbutton12.Click, Stopbutton13.Click, Stopbutton14.Click, Stopbutton15.Click, Stopbutton16.Click, Stopbutton17.Click
        Dim JIndex As Integer = CType(DirectCast(sender, Control).Tag, Integer)
        Stopbuttons(JIndex).Enabled = True
        Stopwatches(JIndex).Stop()
        ResultArray(JIndex).Text = ""
        ResultArray(JIndex).BackColor = Color.WhiteSmoke
        Startbuttons(JIndex).Image = My.Resources.play3
        Startbuttons(JIndex).FlatStyle = FlatStyle.Standard
        Timers(JIndex).Stop()
        If JIndex <= 8 Then
            Spellpics(JIndex).Image = Nothing
        End If
    End Sub

    Sub RewindEventHandler(sender As Object, e As EventArgs) Handles Rewindbutton1.Click, Rewindbutton2.Click, Rewindbutton3.Click, Rewindbutton4.Click, Rewindbutton5.Click, Rewindbutton6.Click, Rewindbutton7.Click, Rewindbutton8.Click, Rewindbutton9.Click, Rewindbutton10.Click, Rewindbutton11.Click, Rewindbutton12.Click, Rewindbutton13.Click, Rewindbutton14.Click, Rewindbutton15.Click, Rewindbutton16.Click, Rewindbutton17.Click
        Dim KIndex As Integer = CType(DirectCast(sender, Control).Tag, Integer)
        Rewindbuttons(KIndex).Enabled = True
        If Not ResultArray(KIndex).Text = "" Or ResultArray(KIndex).Text = "00:00" Then
            spelltimearray(KIndex) = spelltimearray(KIndex) - TimeSpan.FromSeconds(10)
        End If
    End Sub


    Sub StartEventHandler(sender As Object, e As EventArgs) Handles Startbutton1.Click, Startbutton2.Click, Startbutton3.Click, Startbutton4.Click, Startbutton5.Click, Startbutton6.Click, Startbutton7.Click, Startbutton8.Click, Startbutton9.Click, Startbutton10.Click, Startbutton11.Click, Startbutton12.Click, Startbutton13.Click, Startbutton14.Click, Startbutton15.Click, Startbutton16.Click, Startbutton17.Click
        Dim Index As Integer = CType(DirectCast(sender, Control).Tag, Integer)

        Startbuttons(Index).Enabled = True

        Startbuttons(Index).Image = My.Resources.play4
        Startbuttons(Index).FlatStyle = FlatStyle.Flat

        Stopwatches(Index).Reset()

        If Index >= 9 And Index <= 16 Then
        Else
            LabelArray(Index).Text = droparray(Index).Text
        End If

        Dim SpellName As String
        Dim Spell As Single
        SpellName = LabelArray(Index).Text
        Select Case SpellName
            Case Is = "Flash"
                Spell = 300
                Spellpics(Index).Image = My.Resources.Flash
            Case Is = "Ghost"
                Spell = 180
                Spellpics(Index).Image = My.Resources.Ghost
            Case Is = "Teleport"
                Spell = 300
                Spellpics(Index).Image = My.Resources.Teleport
            Case Is = "Ignite"
                Spell = 210
                Spellpics(Index).Image = My.Resources.Ignite
            Case Is = "Exhaust"
                Spell = 210
                Spellpics(Index).Image = My.Resources.Exhaust
            Case Is = "Heal"
                Spell = 240
                Spellpics(Index).Image = My.Resources.Heal
            Case Is = "Barrier"
                Spell = 180
                Spellpics(Index).Image = My.Resources.Barrier
            Case Is = "Cleanse"
                Spell = 210
                Spellpics(Index).Image = My.Resources.Cleanse
            Case Is = "BLUE"
                Spell = 300
            Case Is = "WOLVES"
                Spell = 150
            Case Is = "GROMP"
                Spell = 150
            Case Is = "RED"
                Spell = 300
            Case Is = "RAPTORS"
                Spell = 150
            Case Is = "GOLEMS"
                Spell = 150
            Case Is = "SCUTL1"
                Spell = 180
            Case Is = "SCUTL2"
                Spell = 180
            Case Is = ""
                Startbuttons(Index).Image = My.Resources.play3
                Startbuttons(Index).FlatStyle = FlatStyle.Standard
                Exit Sub
        End Select

        Dim Insight As Single
        If Index >= 9 And Index <= 16 Then
            Insight = 0
        ElseIf InsightArray(Index).Checked = True Then
            Insight = 0.1
        Else
            Insight = 0
        End If


        Dim Ionian As Single
        If Index >= 9 And Index <= 16 Then
            Ionian = 0
        ElseIf IonianArray(Index).Checked = True Then
            Ionian = 0.15
        Else
            Ionian = 0
        End If

        Spell = Spell * (1 - Ionian - Insight)

        spelltimearray(Index) = TimeSpan.FromSeconds(Spell)
        ResultArray(Index).Text = spelltimearray(Index).ToString("mm\:ss")

        Stopwatches(Index).Start()
        Timers(Index).Start()
        Timers(Index).Interval = 1000

    End Sub


    Sub TimerEventHandler(sender As Object, e As EventArgs) Handles Timer1.Tick, Timer2.Tick, Timer3.Tick, Timer4.Tick, Timer5.Tick, Timer6.Tick, Timer7.Tick, Timer8.Tick, Timer9.Tick, Timer10.Tick, Timer11.Tick, Timer12.Tick, Timer13.Tick, Timer14.Tick, Timer15.Tick, Timer16.Tick, Timer17.Tick
        Dim lIndex As Integer = CType(DirectCast(sender, Timer).Tag, Integer)
        Timers(lIndex).Enabled = True

        If Not ResultArray(lIndex).Text = "00:00" Then
            ResultArray(lIndex).BackColor = Color.Pink
            ResultArray(lIndex).Text = (spelltimearray(lIndex) - Stopwatches(lIndex).Elapsed).ToString("mm\:ss")
        Else
            Timers(lIndex).Stop()
            Stopwatches(lIndex).Stop()
            ResultArray(lIndex).Text = ""
            ResultArray(lIndex).BackColor = Color.WhiteSmoke
            Startbuttons(lIndex).Image = My.Resources.play3
            Startbuttons(lIndex).FlatStyle = FlatStyle.Standard
            If lIndex <= 8 Then
                Spellpics(lIndex).Image = Nothing
            End If
        End If

    End Sub


End Class

