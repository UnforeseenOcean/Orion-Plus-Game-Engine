﻿Imports System.Windows.Forms

Public Class frmEditor_Events

#Region "Frm Code"
    Sub ClearConditionFrame()
        Dim i As Long

        cmbCondition_PlayerVarIndex.Enabled = False
        cmbCondition_PlayerVarIndex.Items.Clear()

        For i = 1 To MAX_VARIABLES
            cmbCondition_PlayerVarIndex.Items.Add(i & ". " & Variables(i))
        Next
        cmbCondition_PlayerVarIndex.SelectedIndex = 0
        cmbCondition_PlayerVarCompare.SelectedIndex = 0
        cmbCondition_PlayerVarCompare.Enabled = False
        txtCondition_PlayerVarCondition.Enabled = False
        txtCondition_PlayerVarCondition.Text = "0"
        cmbCondition_PlayerSwitch.Enabled = False
        cmbCondition_PlayerSwitch.Items.Clear()

        For i = 1 To MAX_SWITCHES
            cmbCondition_PlayerSwitch.Items.Add(i & ". " & Switches(i))
        Next
        cmbCondition_PlayerSwitch.SelectedIndex = 0
        cmbCondtion_PlayerSwitchCondition.Enabled = False
        cmbCondtion_PlayerSwitchCondition.SelectedIndex = 0
        cmbCondition_HasItem.Enabled = False
        cmbCondition_HasItem.Items.Clear()

        For i = 1 To MAX_ITEMS
            cmbCondition_HasItem.Items.Add(i & ". " & Trim$(Item(i).Name))
        Next
        cmbCondition_HasItem.SelectedIndex = 0
        scrlCondition_HasItem.Enabled = False
        scrlCondition_HasItem.Value = 1
        cmbCondition_ClassIs.Enabled = False
        cmbCondition_ClassIs.Items.Clear()

        For i = 1 To Max_Classes
            cmbCondition_ClassIs.Items.Add(i & ". " & CStr(Classes(i).Name))
        Next
        cmbCondition_ClassIs.SelectedIndex = 0
        cmbCondition_LearntSkill.Enabled = False
        cmbCondition_LearntSkill.Items.Clear()

        For i = 1 To MAX_SPELLS
            cmbCondition_LearntSkill.Items.Add(i & ". " & Trim$(Spell(i).Name))
        Next
        cmbCondition_LearntSkill.SelectedIndex = 0
        cmbCondition_LevelCompare.Enabled = False
        cmbCondition_LevelCompare.SelectedIndex = 0
        txtCondition_LevelAmount.Enabled = False
        txtCondition_LevelAmount.Text = "0"
        cmbCondition_SelfSwitch.SelectedIndex = 0
        cmbCondition_SelfSwitch.Enabled = False
        cmbCondition_SelfSwitchCondition.SelectedIndex = 0
        cmbCondition_SelfSwitchCondition.Enabled = False
        scrlCondition_Quest.Enabled = False
        scrlCondition_Quest.Value = 1
        lblConditionQuest.Text = "Quest: 1"
        fraConditions_Quest.Visible = False
        optCondition_Quest0.Checked = True
        cmbCondition_General.Enabled = True
        cmbCondition_General.SelectedIndex = 0
        scrlCondition_QuestTask.Value = 1
        lblCondition_QuestTask.Text = "#1"

    End Sub

    Public Sub InitEventEditorForm()
        Dim i As Long

        'scrlShowTextFace.Maximum = NumFaces
        'scrlShowChoicesFace.Maximum = NumFaces
        scrlWPMap.Maximum = MAX_MAPS
        cmbSwitch.Items.Clear()

        For i = 1 To MAX_SWITCHES
            cmbSwitch.Items.Add(i & ". " & Switches(i))
        Next
        cmbSwitch.SelectedIndex = 0
        cmbVariable.Items.Clear()

        For i = 1 To MAX_VARIABLES
            cmbVariable.Items.Add(i & ". " & Variables(i))
        Next
        cmbVariable.SelectedIndex = 0
        cmbChangeItemIndex.Items.Clear()

        For i = 1 To MAX_ITEMS
            cmbChangeItemIndex.Items.Add(Trim$(Item(i).Name))
        Next
        cmbChangeItemIndex.SelectedIndex = 0
        scrlChangeLevel.Minimum = 1
        scrlChangeLevel.Maximum = MAX_LEVELS
        scrlChangeLevel.Value = 1
        lblChangeLevel.Text = "Level: 1"
        cmbChangeSkills.Items.Clear()

        For i = 1 To MAX_SPELLS
            cmbChangeSkills.Items.Add(Trim$(Spell(i).Name))
        Next
        cmbChangeSkills.SelectedIndex = 0
        cmbChangeClass.Items.Clear()

        If Max_Classes > 0 Then
            For i = 1 To Max_Classes
                cmbChangeClass.Items.Add(Trim$(Classes(i).Name))
            Next
            cmbChangeClass.SelectedIndex = 0
        End If
        scrlChangeSprite.Maximum = NumCharacters
        cmbPlayAnim.Items.Clear()

        For i = 1 To MAX_ANIMATIONS
            cmbPlayAnim.Items.Add(i & ". " & Trim$(Animation(i).Name))
        Next
        cmbPlayAnim.SelectedIndex = 0

        cmbPlayBGM.Items.Clear()

        If UBound(MusicCache) > 0 Then
            For i = 1 To UBound(MusicCache)
                cmbPlayBGM.Items.Add(MusicCache(i))
            Next
            cmbPlayBGM.SelectedIndex = 0
            btnCommands34.Enabled = True
        Else
            btnCommands34.Enabled = False
        End If
        cmbPlaySound.Items.Clear()

        If UBound(SoundCache) > 0 Then
            For i = 1 To UBound(SoundCache)
                cmbPlaySound.Items.Add(SoundCache(i))
            Next
            cmbPlaySound.SelectedIndex = 0
            btnCommands36.Enabled = True
        Else
            btnCommands36.Enabled = False
        End If
        cmbOpenShop.Items.Clear()

        For i = 1 To MAX_SHOPS
            cmbOpenShop.Items.Add(i & ". " & Trim$(Shop(i).Name))
        Next
        cmbOpenShop.SelectedIndex = 0
        cmbSpawnNPC.Items.Clear()

        For i = 1 To MAX_MAP_NPCS
            If Map.Npc(i) > 0 Then
                cmbSpawnNPC.Items.Add(i & ". " & Trim$(Npc(Map.Npc(i)).Name))
            Else
                cmbSpawnNPC.Items.Add(i & ". ")
            End If
        Next
        cmbBeginQuest.Items.Clear()

        For i = 1 To MAX_QUESTS
            cmbBeginQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        cmbEndQuest.Items.Clear()

        For i = 1 To MAX_QUESTS
            cmbEndQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        cmbSpawnNPC.SelectedIndex = 0
        'ScrlFogData0.Maximum = NumFogs
        cmbEventQuest.Items.Clear()
        cmbEventQuest.Items.Add("None")
        For i = 1 To MAX_QUESTS
            cmbEventQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        'If NumPics > 0 Then
        'btnCommands45.Enabled = True
        'scrlShowPicture.Maximum = NumPics
        'cmbPicIndex.SelectedIndex = 0
        'Else
        btnCommands45.Enabled = False
        'End If

    End Sub

    Private Sub frmEditor_Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 858
    End Sub

    Private Sub lstvCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvCommands.SelectedIndexChanged
        If lstvCommands.SelectedItems.Count = 0 Then Exit Sub

        MsgBox(lstvCommands.SelectedItems(0).Index + 1)

        Select Case lstvCommands.SelectedItems(0).Index + 1
        'Messages

            'show text
            Case 1
                txtShowText.Text = vbNullString
                fraDialogue.Visible = True
                fraCommand0.Visible = True
                scrlShowTextFace.Value = 0
                fraCommands.Visible = False
            'show choices
            Case 2
                txtChoicePrompt.Text = vbNullString
                txtChoices1.Text = vbNullString
                txtChoices2.Text = vbNullString
                txtChoices3.Text = vbNullString
                txtChoices4.Text = vbNullString
                scrlShowChoicesFace.Value = 0
                fraDialogue.Visible = True
                fraCommand1.Visible = True
                fraCommands.Visible = False
        End Select

    End Sub

#End Region

#Region "Page Buttons"
    Private Sub btnNewPage_Click(sender As Object, e As EventArgs) Handles btnNewPage.Click
        Dim pageCount As Long, i As Long

        If chkGlobal.Checked = 1 Then MsgBox("You cannot have multiple pages on global events!") Exit Sub

        pageCount = tmpEvent.PageCount + 1

        ' redim the array
        ReDim Preserve tmpEvent.Pages(pageCount)

        tmpEvent.PageCount = pageCount

        ' set the tabs
        tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            tabPages.TabPages.Add(Str(i))
        Next
        btnDeletePage.Enabled = True
    End Sub

    Private Sub btnCopyPage_Click(sender As Object, e As EventArgs) Handles btnCopyPage.Click
        CopyEventPage = tmpEvent.Pages(curPageNum)
        btnPastePage.Enabled = True
    End Sub

    Private Sub btnPastePage_Click(sender As Object, e As EventArgs) Handles btnPastePage.Click
        tmpEvent.Pages(curPageNum) = CopyEventPage
        EventEditorLoadPage(curPageNum)
    End Sub

    Private Sub btnDeletePage_Click(sender As Object, e As EventArgs) Handles btnDeletePage.Click
        tmpEvent.Pages(curPageNum) = Nothing
        ' move everything else down a notch
        If curPageNum < tmpEvent.PageCount Then
            For i = curPageNum To tmpEvent.PageCount - 1
                tmpEvent.Pages(i + 1) = tmpEvent.Pages(i)
            Next
        End If
        tmpEvent.PageCount = tmpEvent.PageCount - 1
        ' set the tabs
        tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            tabPages.TabPages.Add("0", Str(i), "")
        Next
        ' set the tab back
        If curPageNum <= tmpEvent.PageCount Then
            tabPages.SelectedIndex = tabPages.TabPages.IndexOfKey(curPageNum)
        Else
            tabPages.SelectedIndex = tabPages.TabPages.IndexOfKey(tmpEvent.PageCount)
        End If
        ' make sure we disable
        If tmpEvent.PageCount <= 1 Then
            btnDeletePage.Enabled = False
        End If

    End Sub

    Private Sub btnClearPage_Click(sender As Object, e As EventArgs) Handles btnClearPage.Click
        tmpEvent.Pages(curPageNum) = Nothing
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        tmpEvent.Name = Trim$(txtName.Text)
    End Sub
#End Region

#Region "Conditional Branch"
    Private Sub optCondition_Index0_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index0.CheckedChanged
        If Not optCondition_Index0.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_PlayerVarIndex.Enabled = True
        cmbCondition_PlayerVarCompare.Enabled = True
        txtCondition_PlayerVarCondition.Enabled = True
    End Sub

    Private Sub optCondition_Index1_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index1.CheckedChanged
        If Not optCondition_Index1.Checked Then Exit Sub

        cmbCondition_PlayerSwitch.Enabled = True
        cmbCondtion_PlayerSwitchCondition.Enabled = True
    End Sub

    Private Sub optCondition_Index2_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index2.CheckedChanged
        If Not optCondition_Index2.Checked Then Exit Sub

        cmbCondition_HasItem.Enabled = True
        scrlCondition_HasItem.Enabled = True
    End Sub

    Private Sub optCondition_Index3_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index3.CheckedChanged
        If Not optCondition_Index3.Checked Then Exit Sub

        cmbCondition_ClassIs.Enabled = True
    End Sub

    Private Sub optCondition_Index4_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index4.CheckedChanged
        If Not optCondition_Index4.Checked Then Exit Sub

        cmbCondition_LearntSkill.Enabled = True
    End Sub

    Private Sub optCondition_Index5_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index5.CheckedChanged
        If Not optCondition_Index5.Checked Then Exit Sub

        cmbCondition_LevelCompare.Enabled = True
        txtCondition_LevelAmount.Enabled = True
    End Sub

    Private Sub optCondition_Index6_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index6.CheckedChanged
        If Not optCondition_Index6.Checked Then Exit Sub

        cmbCondition_SelfSwitch.Enabled = True
        cmbCondition_SelfSwitchCondition.Enabled = True
    End Sub

    Private Sub optCondition_Index7_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition_Index7.CheckedChanged
        If Not optCondition_Index7.Checked Then Exit Sub

        fraConditions_Quest.Visible = True
        scrlCondition_Quest.Enabled = True
    End Sub

#End Region

#Region "Conditions"
    Private Sub chkPlayerVar_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlayerVar.CheckedChanged
        tmpEvent.Pages(curPageNum).chkVariable = chkPlayerVar.Checked
        If chkPlayerVar.Checked = 0 Then
            cmbPlayerVar.Enabled = False
            txtPlayerVariable.Enabled = False
            cmbPlayervarCompare.Enabled = False
        Else
            cmbPlayerVar.Enabled = True
            txtPlayerVariable.Enabled = True
            cmbPlayervarCompare.Enabled = True
        End If
    End Sub

    Private Sub cmbPlayerVar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerVar.SelectedIndexChanged
        If cmbPlayerVar.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).VariableIndex = cmbPlayerVar.SelectedIndex
    End Sub

    Private Sub cmbPlayervarCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayervarCompare.SelectedIndexChanged
        If cmbPlayervarCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).VariableCompare = cmbPlayervarCompare.SelectedIndex
    End Sub

    Private Sub txtPlayerVariable_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerVariable.TextChanged
        tmpEvent.Pages(curPageNum).VariableCondition = Val(Trim$(txtPlayerVariable.Text))
    End Sub

    Private Sub chkPlayerSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlayerSwitch.CheckedChanged
        tmpEvent.Pages(curPageNum).chkSwitch = chkPlayerSwitch.Checked
        If chkPlayerSwitch.Checked = 0 Then
            cmbPlayerSwitch.Enabled = False
            cmbPlayerSwitchCompare.Enabled = False
        Else
            cmbPlayerSwitch.Enabled = True
            cmbPlayerSwitchCompare.Enabled = True
        End If
    End Sub

    Private Sub cmbPlayerSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerSwitch.SelectedIndexChanged
        If cmbPlayerSwitch.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SwitchIndex = cmbPlayerSwitch.SelectedIndex
    End Sub

    Private Sub cmbPlayerSwitchCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerSwitchCompare.SelectedIndexChanged
        If cmbPlayerSwitchCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SwitchCompare = cmbPlayerSwitchCompare.SelectedIndex
    End Sub

    Private Sub chkHasItem_CheckedChanged(sender As Object, e As EventArgs) Handles chkHasItem.CheckedChanged
        tmpEvent.Pages(curPageNum).chkHasItem = chkHasItem.Checked
        If chkHasItem.Checked = 0 Then cmbHasItem.Enabled = False Else cmbHasItem.Enabled = True
    End Sub

    Private Sub cmbHasItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHasItem.SelectedIndexChanged
        If cmbHasItem.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).HasItemIndex = cmbHasItem.SelectedIndex
        tmpEvent.Pages(curPageNum).HasItemAmount = scrlCondition_HasItem.Value
    End Sub

    Private Sub chkSelfSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelfSwitch.CheckedChanged
        tmpEvent.Pages(curPageNum).chkSelfSwitch = chkSelfSwitch.Checked
        If chkSelfSwitch.Checked = 0 Then
            cmbSelfSwitch.Enabled = False
            cmbSelfSwitchCompare.Enabled = False
        Else
            cmbSelfSwitch.Enabled = True
            cmbSelfSwitchCompare.Enabled = True
        End If
    End Sub

    Private Sub cmbSelfSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelfSwitch.SelectedIndexChanged
        If cmbSelfSwitch.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SelfSwitchIndex = cmbSelfSwitch.SelectedIndex
    End Sub

    Private Sub cmbSelfSwitchCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelfSwitchCompare.SelectedIndexChanged
        If cmbSelfSwitchCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SelfSwitchCompare = cmbSelfSwitchCompare.SelectedIndex
    End Sub

#End Region

#Region "Graphic"
    Private Sub picGraphic_Click(sender As Object, e As EventArgs) Handles picGraphic.Click
        fraGraphic.Width = 841
        fraGraphic.Height = 585
        fraGraphic.BringToFront()
        fraGraphic.Visible = True
        GraphicSelType = 0
    End Sub


#End Region

#Region "Movement"
    Private Sub cmbMoveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveType.SelectedIndexChanged
        If cmbMoveType.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveType = cmbMoveType.SelectedIndex
        If cmbMoveType.SelectedIndex = 2 Then
            btnMoveRoute.Enabled = True
        Else
            btnMoveRoute.Enabled = False
        End If
    End Sub

    Private Sub btnMoveRoute_Click(sender As Object, e As EventArgs) Handles btnMoveRoute.Click
        fraMoveRoute.Visible = True
        lstMoveRoute.Items.Clear()
        cmbEvent.Items.Clear()
        cmbEvent.Items.Add("This Event")
        cmbEvent.SelectedIndex = 0
        cmbEvent.Enabled = False
        IsMoveRouteCommand = False
        chkIgnoreMove.Checked = tmpEvent.Pages(curPageNum).IgnoreMoveRoute
        chkRepeatRoute.Checked = tmpEvent.Pages(curPageNum).RepeatMoveRoute
        TempMoveRouteCount = tmpEvent.Pages(curPageNum).MoveRouteCount

        'Will it let me do this?
        TempMoveRoute = tmpEvent.Pages(curPageNum).MoveRoute
        For i = 1 To TempMoveRouteCount
            Select Case TempMoveRoute(i).Index
                Case 1
                    lstMoveRoute.Items.Add("Move Up")
                Case 2
                    lstMoveRoute.Items.Add("Move Down")
                Case 3
                    lstMoveRoute.Items.Add("Move Left")
                Case 4
                    lstMoveRoute.Items.Add("Move Right")
                Case 5
                    lstMoveRoute.Items.Add("Move Randomly")
                Case 6
                    lstMoveRoute.Items.Add("Move Towards Player")
                Case 7
                    lstMoveRoute.Items.Add("Move Away From Player")
                Case 8
                    lstMoveRoute.Items.Add("Step Forward")
                Case 9
                    lstMoveRoute.Items.Add("Step Back")
                Case 10
                    lstMoveRoute.Items.Add("Wait 100ms")
                Case 11
                    lstMoveRoute.Items.Add("Wait 500ms")
                Case 12
                    lstMoveRoute.Items.Add("Wait 1000ms")
                Case 13
                    lstMoveRoute.Items.Add("Turn Up")
                Case 14
                    lstMoveRoute.Items.Add("Turn Down")
                Case 15
                    lstMoveRoute.Items.Add("Turn Left")
                Case 16
                    lstMoveRoute.Items.Add("Turn Right")
                Case 17
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Right")
                Case 18
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Left")
                Case 19
                    lstMoveRoute.Items.Add("Turn Around 180 Degrees")
                Case 20
                    lstMoveRoute.Items.Add("Turn Randomly")
                Case 21
                    lstMoveRoute.Items.Add("Turn Towards Player")
                Case 22
                    lstMoveRoute.Items.Add("Turn Away from Player")
                Case 23
                    lstMoveRoute.Items.Add("Set Speed 8x Slower")
                Case 24
                    lstMoveRoute.Items.Add("Set Speed 4x Slower")
                Case 25
                    lstMoveRoute.Items.Add("Set Speed 2x Slower")
                Case 26
                    lstMoveRoute.Items.Add("Set Speed to Normal")
                Case 27
                    lstMoveRoute.Items.Add("Set Speed 2x Faster")
                Case 28
                    lstMoveRoute.Items.Add("Set Speed 4x Faster")
                Case 29
                    lstMoveRoute.Items.Add("Set Frequency Lowest")
                Case 30
                    lstMoveRoute.Items.Add("Set Frequency Lower")
                Case 31
                    lstMoveRoute.Items.Add("Set Frequency Normal")
                Case 32
                    lstMoveRoute.Items.Add("Set Frequency Higher")
                Case 33
                    lstMoveRoute.Items.Add("Set Frequency Highest")
                Case 34
                    lstMoveRoute.Items.Add("Turn On Walking Animation")
                Case 35
                    lstMoveRoute.Items.Add("Turn Off Walking Animation")
                Case 36
                    lstMoveRoute.Items.Add("Turn On Fixed Direction")
                Case 37
                    lstMoveRoute.Items.Add("Turn Off Fixed Direction")
                Case 38
                    lstMoveRoute.Items.Add("Turn On Walk Through")
                Case 39
                    lstMoveRoute.Items.Add("Turn Off Walk Through")
                Case 40
                    lstMoveRoute.Items.Add("Set Position Below Player")
                Case 41
                    lstMoveRoute.Items.Add("Set Position at Player Level")
                Case 42
                    lstMoveRoute.Items.Add("Set Position Above Player")
                Case 43
                    lstMoveRoute.Items.Add("Set Graphic")
            End Select
        Next
        fraMoveRoute.Width = 841
        fraMoveRoute.Height = 585
        fraMoveRoute.Visible = True

    End Sub

    Private Sub cmbMoveSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveSpeed.SelectedIndexChanged
        If cmbMoveSpeed.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveSpeed = cmbMoveSpeed.SelectedIndex
    End Sub

    Private Sub cmbMoveFreq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveFreq.SelectedIndexChanged
        If cmbMoveFreq.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveFreq = cmbMoveFreq.SelectedIndex
    End Sub


#End Region

#Region "Positioning"
    Private Sub cmbPositioning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPositioning.SelectedIndexChanged
        If cmbPositioning.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).Position = cmbPositioning.SelectedIndex
    End Sub
#End Region

#Region "Trigger"
    Private Sub cmbTrigger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrigger.SelectedIndexChanged
        If cmbTrigger.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).Trigger = cmbTrigger.SelectedIndex
    End Sub
#End Region

#Region "Global"
    Private Sub chkGlobal_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlobal.CheckedChanged
        If tmpEvent.PageCount > 1 Then
            If MsgBox("If you set the event to global you will lose all pages except for your first one. Do you want to continue?", vbYesNo) = vbNo Then
                Exit Sub
            End If
        End If
        tmpEvent.Globals = chkGlobal.Checked
        tmpEvent.PageCount = 1
        curPageNum = 1
        Me.tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            Me.tabPages.TabPages.Add("0", Str(i), "0")
        Next
        EventEditorLoadPage(curPageNum)
    End Sub
#End Region

#Region "QuestIcon"
    Private Sub cmbEventQuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEventQuest.SelectedIndexChanged
        tmpEvent.Pages(curPageNum).Questnum = cmbEventQuest.SelectedIndex
    End Sub
#End Region

#Region "Options"
    Private Sub chkWalkAnim_CheckedChanged(sender As Object, e As EventArgs) Handles chkWalkAnim.CheckedChanged
        tmpEvent.Pages(curPageNum).WalkAnim = chkWalkAnim.Checked
    End Sub

    Private Sub chkDirFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkDirFix.CheckedChanged
        tmpEvent.Pages(curPageNum).DirFix = chkDirFix.Checked
    End Sub

    Private Sub chkWalkThrough_CheckedChanged(sender As Object, e As EventArgs) Handles chkWalkThrough.CheckedChanged
        tmpEvent.Pages(curPageNum).WalkThrough = chkWalkThrough.Checked
    End Sub

    Private Sub chkShowName_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowName.CheckedChanged
        tmpEvent.Pages(curPageNum).ShowName = chkShowName.Checked
    End Sub
#End Region

#Region "Commands"
    Private Sub lstCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCommands.SelectedIndexChanged
        curCommand = lstCommands.SelectedIndex + 1
    End Sub

    Private Sub btnAddCommand_Click(sender As Object, e As EventArgs) Handles btnAddCommand.Click
        If lstCommands.SelectedIndex > -1 Then
            isEdit = False
            tabCommands.SelectedTab = TabPage1
            fraCommands.Visible = True
        End If
    End Sub

    Private Sub btnEditCommand_Click(sender As Object, e As EventArgs) Handles btnEditCommand.Click
        If lstCommands.SelectedIndex > -1 Then
            EditEventCommand()
        End If
    End Sub

    Private Sub btnDeleteComand_Click(sender As Object, e As EventArgs) Handles btnDeleteComand.Click
        If lstCommands.SelectedIndex > -1 Then
            DeleteEventCommand()
        End If

    End Sub

    Private Sub btnClearCommand_Click(sender As Object, e As EventArgs) Handles btnClearCommand.Click
        If MsgBox("Are you sure you want to clear all event commands?", vbYesNo, "Clear Event Commands?") = vbYes Then
            ClearEventCommands()
        End If
    End Sub
#End Region

#Region "ButtonCommands"

    'chatbox text
    Private Sub btnCommands2_Click(sender As Object, e As EventArgs) Handles btnCommands2.Click
        txtAddText_Text.Text = vbNullString
        scrlAddText_Colour.Value = 0
        optAddText_Player.Checked = True
        fraDialogue.Visible = True
        fraCommand2.Visible = True
        fraCommands.Visible = False
    End Sub

    'chat bubble
    Private Sub btnCommands3_Click(sender As Object, e As EventArgs) Handles btnCommands3.Click
        txtChatbubbleText.Text = ""
        optChatBubbleTarget0.Checked = True
        cmbChatBubbleTarget.Visible = False
        fraDialogue.Visible = True
        fraCommand3.Visible = True
        fraCommands.Visible = False
    End Sub

    'event progression

    'player variable
    Private Sub btnCommands4_Click(sender As Object, e As EventArgs) Handles btnCommands4.Click
        txtVariableData0.Text = 0
        txtVariableData1.Text = 0
        txtVariableData2.Text = 0
        txtVariableData3.Text = 0
        txtVariableData4.Text = 0

        cmbVariable.SelectedIndex = 0
        optVariableAction0.Checked = True
        fraDialogue.Visible = True
        fraCommand4.Visible = True
        fraCommands.Visible = False
    End Sub

    'player switch
    Private Sub btnCommands5_Click(sender As Object, e As EventArgs) Handles btnCommands5.Click
        cmbPlayerSwitchSet.SelectedIndex = 0
        cmbSwitch.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand5.Visible = True
        fraCommands.Visible = False
    End Sub

    'self switch
    Private Sub btnCommands6_Click(sender As Object, e As EventArgs) Handles btnCommands6.Click
        cmbSetSelfSwitchTo.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand6.Visible = True
        fraCommands.Visible = False
    End Sub

    'flow control

    'conditional branch
    Private Sub btnCommands7_Click(sender As Object, e As EventArgs) Handles btnCommands7.Click
        fraDialogue.Visible = True
        fraCommand7.Visible = True
        optCondition_Index0.Checked = True
        ClearConditionFrame()
        cmbCondition_PlayerVarIndex.Enabled = True
        cmbCondition_PlayerVarCompare.Enabled = True
        txtCondition_PlayerVarCondition.Enabled = True
        fraCommands.Visible = False
    End Sub

    'Exit Event Process
    Private Sub btnCommands8_Click(sender As Object, e As EventArgs) Handles btnCommands8.Click
        AddCommand(EventType.evExitProcess)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Label
    Private Sub btnCommands9_Click(sender As Object, e As EventArgs) Handles btnCommands9.Click
        txtLabelName.Text = ""
        fraCommand8.Visible = True
        fraCommands.Visible = False
        fraDialogue.Visible = True
    End Sub

    'GoTo Label
    Private Sub btnCommands10_Click(sender As Object, e As EventArgs) Handles btnCommands10.Click
        txtGotoLabel.Text = ""
        fraCommand9.Visible = True
        fraCommands.Visible = False
        fraDialogue.Visible = True
    End Sub

    'Player Control

    'Change Items
    Private Sub btnCommands11_Click(sender As Object, e As EventArgs) Handles btnCommands11.Click
        cmbChangeItemIndex.SelectedIndex = 0
        optChangeItemSet.Checked = True
        txtChangeItemsAmount.Text = "0"
        fraDialogue.Visible = True
        fraCommand10.Visible = True
        fraCommands.Visible = False
    End Sub

    'Restore Hp
    Private Sub btnCommands12_Click(sender As Object, e As EventArgs) Handles btnCommands12.Click
        AddCommand(EventType.evRestoreHP)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Restore Mp
    Private Sub btnCommands13_Click(sender As Object, e As EventArgs) Handles btnCommands13.Click
        AddCommand(EventType.evRestoreMP)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Level Up
    Private Sub btnCommands14_Click(sender As Object, e As EventArgs) Handles btnCommands14.Click
        AddCommand(EventType.evLevelUp)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Change Level
    Private Sub btnCommands15_Click(sender As Object, e As EventArgs) Handles btnCommands15.Click
        scrlChangeLevel.Value = 1
        lblChangeLevel.Text = "Level: 1"
        fraDialogue.Visible = True
        fraCommand11.Visible = True
        fraCommands.Visible = False
    End Sub

    'Change Skills
    Private Sub btnCommands16_Click(sender As Object, e As EventArgs) Handles btnCommands16.Click
        cmbChangeSkills.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand12.Visible = True
        fraCommands.Visible = False
    End Sub

    'Change Class
    Private Sub btnCommands17_Click(sender As Object, e As EventArgs) Handles btnCommands17.Click
        If Max_Classes > 0 Then
            If cmbChangeClass.Items.Count = 0 Then
                cmbChangeClass.Items.Clear()

                For i = 1 To Max_Classes
                    cmbChangeClass.Items.Add(Trim$(Classes(i).Name))
                Next
                cmbChangeClass.SelectedIndex = 0
            End If
        End If
        fraDialogue.Visible = True
        fraCommand13.Visible = True
        fraCommands.Visible = False
    End Sub

    'Change Sprite
    Private Sub btnCommands18_Click(sender As Object, e As EventArgs) Handles btnCommands18.Click
        scrlChangeSprite.Value = 1
        lblChangeSprite.Text = "Sprite: 1"
        fraDialogue.Visible = True
        fraCommand14.Visible = True
        fraCommands.Visible = False
    End Sub

    'Change Gender
    Private Sub btnCommands19_Click(sender As Object, e As EventArgs) Handles btnCommands19.Click
        optChangeSexMale.Checked = True
        fraDialogue.Visible = True
        fraCommand15.Visible = True
        fraCommands.Visible = False
    End Sub

    'Change PK
    Private Sub btnCommands20_Click(sender As Object, e As EventArgs) Handles btnCommands20.Click
        optChangePKYes.Checked = True
        fraDialogue.Visible = True
        fraCommand16.Visible = True
        fraCommands.Visible = False
    End Sub

    'Give Exp
    Private Sub btnCommands21_Click(sender As Object, e As EventArgs) Handles btnCommands21.Click
        scrlGiveExp.Value = 0
        lblGiveExp.Text = "Give Exp: 0"
        fraDialogue.Visible = True
        fraCommand17.Visible = True
        fraCommands.Visible = False
    End Sub

    'Movement

    'Warp Player
    Private Sub btnCommands22_Click(sender As Object, e As EventArgs) Handles btnCommands22.Click
        scrlWPMap.Value = 0
        scrlWPX.Value = 0
        scrlWPY.Value = 0
        cmbWarpPlayerDir.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand18.Visible = True
        fraCommands.Visible = False
    End Sub

    'Set Move Route
    Private Sub btnCommands23_Click(sender As Object, e As EventArgs) Handles btnCommands23.Click
        Dim x As Long

        fraMoveRoute.Visible = True
        lstMoveRoute.Items.Clear()
        cmbEvent.Items.Clear()
        ReDim ListOfEvents(0 To Map.EventCount)
        ListOfEvents(0) = EditorEvent
        cmbEvent.Items.Add("This Event")
        cmbEvent.SelectedIndex = 0
        cmbEvent.Enabled = True
        For i = 1 To Map.EventCount
            If i <> EditorEvent Then
                cmbEvent.Items.Add(Trim$(Map.Events(i).Name))
                x = x + 1
                ListOfEvents(x) = i
            End If
        Next
        IsMoveRouteCommand = True
        chkIgnoreMove.Checked = 0
        chkRepeatRoute.Checked = 0
        TempMoveRouteCount = 0
        ReDim TempMoveRoute(0)
        fraMoveRoute.Width = 841
        fraMoveRoute.Height = 585
        fraMoveRoute.Visible = True
        fraCommands.Visible = False
    End Sub

    'Wait for Route Completion
    Private Sub btnCommands24_Click(sender As Object, e As EventArgs) Handles btnCommands24.Click
        Dim x As Long

        cmbMoveWait.Items.Clear()
        ReDim ListOfEvents(0 To Map.EventCount)
        ListOfEvents(0) = EditorEvent
        cmbMoveWait.Items.Add("This Event")
        cmbMoveWait.SelectedIndex = 0
        cmbMoveWait.Enabled = True
        For i = 1 To Map.EventCount
            If i <> EditorEvent Then
                cmbMoveWait.Items.Add(Trim$(Map.Events(i).Name))
                x = x + 1
                ListOfEvents(x) = i
            End If
        Next
        fraDialogue.Visible = True
        fraCommand35.Visible = True
        fraCommands.Visible = False
    End Sub

    'Spawn Npc
    Private Sub btnCommands25_Click(sender As Object, e As EventArgs) Handles btnCommands25.Click
        cmbSpawnNPC.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand19.Visible = True
        fraCommands.Visible = False
    End Sub

    'Hold Player
    Private Sub btnCommands26_Click(sender As Object, e As EventArgs) Handles btnCommands26.Click
        AddCommand(EventType.evHoldPlayer)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Release Player
    Private Sub btnCommands27_Click(sender As Object, e As EventArgs) Handles btnCommands27.Click
        AddCommand(EventType.evReleasePlayer)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Animation

    'Play Animation
    Private Sub btnCommands28_Click(sender As Object, e As EventArgs) Handles btnCommands28.Click
        cmbPlayAnimEvent.Items.Clear()

        For i = 1 To Map.EventCount
            cmbPlayAnimEvent.Items.Add(i & ". " & Trim$(Map.Events(i).Name))
        Next
        cmbPlayAnimEvent.SelectedIndex = 0
        optPlayAnimPlayer.Checked = True
        cmbPlayAnim.SelectedIndex = 0
        lblPlayAnimX.Text = "Map Tile X: 0"
        lblPlayAnimY.Text = "Map Tile Y: 0"
        scrlPlayAnimTileX.Value = 0
        scrlPlayAnimTileY.Value = 0
        scrlPlayAnimTileX.Maximum = Map.MaxX
        scrlPlayAnimTileY.Maximum = Map.MaxY
        fraDialogue.Visible = True
        fraCommand20.Visible = True
        fraCommands.Visible = False
        lblPlayAnimX.Visible = False
        lblPlayAnimY.Visible = False
        scrlPlayAnimTileX.Visible = False
        scrlPlayAnimTileY.Visible = False
        cmbPlayAnimEvent.Visible = False
    End Sub

    'Quests

    'Begin Quest
    Private Sub btnCommands29_Click(sender As Object, e As EventArgs) Handles btnCommands29.Click
        cmbBeginQuest.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand30.Visible = True
        fraCommands.Visible = False
    End Sub

    'Complete Give/Talk Task
    Private Sub btnCommands30_Click(sender As Object, e As EventArgs) Handles btnCommands30.Click
        scrlCompleteQuestTaskQuest.Value = 1
        scrlCompleteQuestTask.Value = 1
        fraDialogue.Visible = True
        fraCommand32.Visible = True
        fraCommands.Visible = False
    End Sub

    'End Quest
    Private Sub btnCommands31_Click(sender As Object, e As EventArgs) Handles btnCommands31.Click
        cmbEndQuest.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand31.Visible = True
        fraCommands.Visible = False
    End Sub

    'Map Functions

    'Set Fog
    Private Sub btnCommands32_Click(sender As Object, e As EventArgs) Handles btnCommands32.Click
        ScrlFogData0.Value = 0
        ScrlFogData1.Value = 0
        ScrlFogData2.Value = 0
        fraDialogue.Visible = True
        fraCommand22.Visible = True
        fraCommands.Visible = False
    End Sub

    'Set Weather
    Private Sub btnCommands33_Click(sender As Object, e As EventArgs) Handles btnCommands33.Click
        CmbWeather.SelectedIndex = 0
        scrlWeatherIntensity.Value = 0
        fraDialogue.Visible = True
        fraCommand23.Visible = True
        fraCommands.Visible = False
    End Sub

    'Set Map Tinting
    Private Sub btnCommands34_Click(sender As Object, e As EventArgs) Handles btnCommands34.Click
        scrlMapTintData0.Value = 0
        scrlMapTintData1.Value = 0
        scrlMapTintData2.Value = 0
        scrlMapTintData3.Value = 0
        fraDialogue.Visible = True
        fraCommand24.Visible = True
        fraCommands.Visible = False
    End Sub

    'Music and Sound

    'PlayBGM
    Private Sub btnCommands35_Click(sender As Object, e As EventArgs) Handles btnCommands35.Click
        cmbPlayBGM.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand25.Visible = True
        fraCommands.Visible = False
    End Sub

    'Fadeout BGM
    Private Sub btnCommands36_Click(sender As Object, e As EventArgs) Handles btnCommands36.Click
        AddCommand(EventType.evFadeoutBGM)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Play Sound
    Private Sub btnCommands37_Click(sender As Object, e As EventArgs) Handles btnCommands37.Click
        cmbPlaySound.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand26.Visible = True
        fraCommands.Visible = False
    End Sub

    'Stop Sounds
    Private Sub btnCommands38_Click(sender As Object, e As EventArgs) Handles btnCommands38.Click
        AddCommand(EventType.evStopSound)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Etc...

    'Wait
    Private Sub btnCommands39_Click(sender As Object, e As EventArgs) Handles btnCommands39.Click
        scrlWaitAmount.Value = 1
        fraDialogue.Visible = True
        fraCommand27.Visible = True
        fraCommands.Visible = False
    End Sub

    'Set Access
    Private Sub btnCommands40_Click(sender As Object, e As EventArgs) Handles btnCommands40.Click
        cmbSetAccess.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand28.Visible = True
        fraCommands.Visible = False
    End Sub

    'Custom Script
    Private Sub btnCommands41_Click(sender As Object, e As EventArgs) Handles btnCommands41.Click
        scrlCustomScript.Value = 1
        fraDialogue.Visible = True
        fraCommand29.Visible = True
        fraCommands.Visible = False
    End Sub

    'cutscene options

    'Fade in
    Private Sub btnCommands42_Click(sender As Object, e As EventArgs) Handles btnCommands42.Click
        AddCommand(EventType.evFadeIn)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Fade out
    Private Sub btnCommands43_Click(sender As Object, e As EventArgs) Handles btnCommands43.Click
        AddCommand(EventType.evFadeOut)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Flash white
    Private Sub btnCommands44_Click(sender As Object, e As EventArgs) Handles btnCommands44.Click
        AddCommand(EventType.evFlashWhite)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Show pic
    Private Sub btnCommands45_Click(sender As Object, e As EventArgs) Handles btnCommands45.Click
        cmbPicIndex.SelectedIndex = 0
        scrlShowPicture.Value = 1
        optPic1.Checked = 1
        txtPicOffset1.Text = 0
        txtPicOffset2.Text = 0
        fraDialogue.Visible = True
        fraCommand33.Visible = True
        fraCommands.Visible = False
    End Sub

    'Hide pic
    Private Sub btnCommands46_Click(sender As Object, e As EventArgs) Handles btnCommands46.Click
        cmbHidePic.SelectedIndex = 0
        fraDialogue.Visible = True
        fraCommand34.Visible = True
        fraCommands.Visible = False
    End Sub

    'Shop, bank etc

    'Open bank
    Private Sub btnCommands47_Click(sender As Object, e As EventArgs) Handles btnCommands47.Click
        AddCommand(EventType.evOpenBank)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    'Open shop
    Private Sub btnCommands48_Click(sender As Object, e As EventArgs) Handles btnCommands48.Click
        fraDialogue.Visible = True
        fraCommand21.Visible = True
        cmbOpenShop.SelectedIndex = 0
        fraCommands.Visible = False
    End Sub

    Private Sub btnCommands49_Click(sender As Object, e As EventArgs) Handles btnCommands49.Click
        AddCommand(EventType.evOpenMail)
        fraCommands.Visible = False
        fraDialogue.Visible = False
    End Sub

    Private Sub btnCancelCommand_Click(sender As Object, e As EventArgs) Handles btnCancelCommand.Click
        fraCommands.Visible = False
    End Sub

#End Region

#Region "Variables/Switches"
    'Renaming Variables/Switches
    Private Sub btnLabeling_Click(sender As Object, e As EventArgs) Handles btnLabeling.Click
        pnlVariableSwitches.Visible = True
        fraLabeling.Visible = True
        fraLabeling.Width = 849
        fraLabeling.Height = 593
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0
    End Sub

    Private Sub btnRename_Ok_Click(sender As Object, e As EventArgs) Handles btnRename_Ok.Click
        Select Case RenameType
            Case 1
                'Variable
                If RenameIndex > 0 And RenameIndex <= MAX_VARIABLES + 1 Then
                    Variables(RenameIndex) = txtRename.Text
                    FraRenaming.Visible = False
                    RenameType = 0
                    RenameIndex = 0
                End If
            Case 2
                'Switch
                If RenameIndex > 0 And RenameIndex <= MAX_SWITCHES + 1 Then
                    Switches(RenameIndex) = txtRename.Text
                    FraRenaming.Visible = False
                    RenameType = 0
                    RenameIndex = 0
                End If
        End Select
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0
    End Sub

    Private Sub btnRename_Cancel_Click(sender As Object, e As EventArgs) Handles btnRename_Cancel.Click
        FraRenaming.Visible = False
        RenameType = 0
        RenameIndex = 0
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0
    End Sub

    Private Sub txtRename_TextChanged(sender As Object, e As EventArgs) Handles txtRename.TextChanged
        tmpEvent.Name = Trim$(txtName.Text)
    End Sub

    Private Sub lstVariables_DoubleClick(sender As Object, e As EventArgs) Handles lstVariables.DoubleClick
        If lstVariables.SelectedIndex > -1 And lstVariables.SelectedIndex < MAX_VARIABLES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Variable #" & CStr(lstVariables.SelectedIndex + 1)
            txtRename.Text = Variables(lstVariables.SelectedIndex + 1)
            RenameType = 1
            RenameIndex = lstVariables.SelectedIndex + 1
        End If
    End Sub

    Private Sub lstSwitches_DoubleClick(sender As Object, e As EventArgs) Handles lstSwitches.DoubleClick
        If lstSwitches.SelectedIndex > -1 And lstSwitches.SelectedIndex < MAX_SWITCHES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Switch #" & CStr(lstSwitches.SelectedIndex + 1)
            txtRename.Text = Switches(lstSwitches.SelectedIndex + 1)
            RenameType = 2
            RenameIndex = lstSwitches.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnRenameVariable_Click(sender As Object, e As EventArgs) Handles btnRenameVariable.Click
        If lstVariables.SelectedIndex > -1 And lstVariables.SelectedIndex < MAX_VARIABLES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Variable #" & CStr(lstVariables.SelectedIndex + 1)
            txtRename.Text = Variables(lstVariables.SelectedIndex + 1)
            RenameType = 1
            RenameIndex = lstVariables.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnRenameSwitch_Click(sender As Object, e As EventArgs) Handles btnRenameSwitch.Click
        If lstSwitches.SelectedIndex > -1 And lstSwitches.SelectedIndex < MAX_SWITCHES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Switch #" & CStr(lstSwitches.SelectedIndex + 1)
            txtRename.Text = Switches(lstSwitches.SelectedIndex + 1)
            RenameType = 2
            RenameIndex = lstSwitches.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnLabel_Ok_Click(sender As Object, e As EventArgs) Handles btnLabel_Ok.Click
        pnlVariableSwitches.Visible = False
        fraLabeling.Visible = False
        SendSwitchesAndVariables()
    End Sub

    Private Sub btnLabel_Cancel_Click(sender As Object, e As EventArgs) Handles btnLabel_Cancel.Click
        pnlVariableSwitches.Visible = False
        fraLabeling.Visible = False
        RequestSwitchesAndVariables()
    End Sub

#End Region

#Region "Move Route"
    Private Sub cmbEvent_Click(sender As Object, e As EventArgs) Handles cmbEvent.Click

    End Sub

    Private Sub lstMoveRoute_KeyDown(sender As Object, e As KeyEventArgs) Handles lstMoveRoute.KeyDown
        If e.KeyCode = Keys.Delete Then
            'remove move route command lol
            If lstMoveRoute.SelectedIndex > -1 Then
                Call RemoveMoveRouteCommand(lstMoveRoute.SelectedIndex)
            End If
        End If
    End Sub

    Sub AddMoveRouteCommand(Index As Integer)
        Dim i As Long, X As Long

        Index = Index + 1
        If lstMoveRoute.SelectedIndex > -1 Then
            i = lstMoveRoute.SelectedIndex + 1
            TempMoveRouteCount = TempMoveRouteCount + 1
            ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            For X = TempMoveRouteCount - 1 To i Step -1
                TempMoveRoute(X + 1) = TempMoveRoute(X)
            Next
            TempMoveRoute(i).Index = Index
            'if set graphic then...
            If Index = 43 Then
                TempMoveRoute(i).Data1 = cmbGraphic.SelectedIndex
                TempMoveRoute(i).Data2 = scrlGraphic.Value
                TempMoveRoute(i).Data3 = GraphicSelX
                TempMoveRoute(i).Data4 = GraphicSelX2
                TempMoveRoute(i).Data5 = GraphicSelY
                TempMoveRoute(i).Data6 = GraphicSelY2
            End If
            PopulateMoveRouteList
        Else
            TempMoveRouteCount = TempMoveRouteCount + 1
            ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            TempMoveRoute(TempMoveRouteCount).Index = Index
            PopulateMoveRouteList
            'if set graphic then....
            If Index = 43 Then
                TempMoveRoute(TempMoveRouteCount).Data1 = cmbGraphic.SelectedIndex
                TempMoveRoute(TempMoveRouteCount).Data2 = scrlGraphic.Value
                TempMoveRoute(TempMoveRouteCount).Data3 = GraphicSelX
                TempMoveRoute(TempMoveRouteCount).Data4 = GraphicSelX2
                TempMoveRoute(TempMoveRouteCount).Data5 = GraphicSelY
                TempMoveRoute(TempMoveRouteCount).Data6 = GraphicSelY2
            End If
        End If

    End Sub

    Sub RemoveMoveRouteCommand(Index As Long)
        Dim i As Long

        Index = Index + 1
        If Index > 0 And Index <= TempMoveRouteCount Then
            For i = Index + 1 To TempMoveRouteCount
                TempMoveRoute(i - 1) = TempMoveRoute(i)
            Next
            TempMoveRouteCount = TempMoveRouteCount - 1
            If TempMoveRouteCount = 0 Then
                ReDim TempMoveRoute(0)
            Else
                ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            End If
            PopulateMoveRouteList
        End If

    End Sub

    Sub PopulateMoveRouteList()
        Dim i As Long

        lstMoveRoute.Items.Clear()

        For i = 1 To TempMoveRouteCount
            Select Case TempMoveRoute(i).Index
                Case 1
                    lstMoveRoute.Items.Add("Move Up")
                Case 2
                    lstMoveRoute.Items.Add("Move Down")
                Case 3
                    lstMoveRoute.Items.Add("Move Left")
                Case 4
                    lstMoveRoute.Items.Add("Move Right")
                Case 5
                    lstMoveRoute.Items.Add("Move Randomly")
                Case 6
                    lstMoveRoute.Items.Add("Move Towards Player")
                Case 7
                    lstMoveRoute.Items.Add("Move Away From Player")
                Case 8
                    lstMoveRoute.Items.Add("Step Forward")
                Case 9
                    lstMoveRoute.Items.Add("Step Back")
                Case 10
                    lstMoveRoute.Items.Add("Wait 100ms")
                Case 11
                    lstMoveRoute.Items.Add("Wait 500ms")
                Case 12
                    lstMoveRoute.Items.Add("Wait 1000ms")
                Case 13
                    lstMoveRoute.Items.Add("Turn Up")
                Case 14
                    lstMoveRoute.Items.Add("Turn Down")
                Case 15
                    lstMoveRoute.Items.Add("Turn Left")
                Case 16
                    lstMoveRoute.Items.Add("Turn Right")
                Case 17
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Right")
                Case 18
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Left")
                Case 19
                    lstMoveRoute.Items.Add("Turn Around 180 Degrees")
                Case 20
                    lstMoveRoute.Items.Add("Turn Randomly")
                Case 21
                    lstMoveRoute.Items.Add("Turn Towards Player")
                Case 22
                    lstMoveRoute.Items.Add("Turn Away from Player")
                Case 23
                    lstMoveRoute.Items.Add("Set Speed 8x Slower")
                Case 24
                    lstMoveRoute.Items.Add("Set Speed 4x Slower")
                Case 25
                    lstMoveRoute.Items.Add("Set Speed 2x Slower")
                Case 26
                    lstMoveRoute.Items.Add("Set Speed to Normal")
                Case 27
                    lstMoveRoute.Items.Add("Set Speed 2x Faster")
                Case 28
                    lstMoveRoute.Items.Add("Set Speed 4x Faster")
                Case 29
                    lstMoveRoute.Items.Add("Set Frequency Lowest")
                Case 30
                    lstMoveRoute.Items.Add("Set Frequency Lower")
                Case 31
                    lstMoveRoute.Items.Add("Set Frequency Normal")
                Case 32
                    lstMoveRoute.Items.Add("Set Frequency Higher")
                Case 33
                    lstMoveRoute.Items.Add("Set Frequency Highest")
                Case 34
                    lstMoveRoute.Items.Add("Turn On Walking Animation")
                Case 35
                    lstMoveRoute.Items.Add("Turn Off Walking Animation")
                Case 36
                    lstMoveRoute.Items.Add("Turn On Fixed Direction")
                Case 37
                    lstMoveRoute.Items.Add("Turn Off Fixed Direction")
                Case 38
                    lstMoveRoute.Items.Add("Turn On Walk Through")
                Case 39
                    lstMoveRoute.Items.Add("Turn Off Walk Through")
                Case 40
                    lstMoveRoute.Items.Add("Set Position Below Player")
                Case 41
                    lstMoveRoute.Items.Add("Set Position at Player Level")
                Case 42
                    lstMoveRoute.Items.Add("Set Position Above Player")
                Case 43
                    lstMoveRoute.Items.Add("Set Graphic")
            End Select
        Next

    End Sub

    Private Sub chkIgnoreMove_CheckedChanged(sender As Object, e As EventArgs) Handles chkIgnoreMove.CheckedChanged
        tmpEvent.Pages(curPageNum).IgnoreMoveRoute = chkIgnoreMove.Checked
    End Sub

    Private Sub chkRepeatRoute_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepeatRoute.CheckedChanged
        tmpEvent.Pages(curPageNum).RepeatMoveRoute = chkRepeatRoute.Checked
    End Sub

    Private Sub btnMoveRouteOk_Click(sender As Object, e As EventArgs) Handles btnMoveRouteOk.Click
        If IsMoveRouteCommand = True Then
            If Not isEdit Then
                AddCommand(EventType.evSetMoveRoute)
            Else
                EditCommand()
            End If
            TempMoveRouteCount = 0
            ReDim TempMoveRoute(0)
            fraMoveRoute.Visible = False
        Else
            tmpEvent.Pages(curPageNum).MoveRouteCount = TempMoveRouteCount
            tmpEvent.Pages(curPageNum).MoveRoute = TempMoveRoute
            TempMoveRouteCount = 0
            ReDim TempMoveRoute(0)
            fraMoveRoute.Visible = False
        End If
    End Sub

    Private Sub btnMoveRouteCancel_Click(sender As Object, e As EventArgs) Handles btnMoveRouteCancel.Click
        TempMoveRouteCount = 0
        ReDim TempMoveRoute(0)
        fraMoveRoute.Visible = False
    End Sub

    'Commands

    'Move Up
    Private Sub btnAddMoveRoute1_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute1.Click
        AddMoveRouteCommand(1)
    End Sub

    'Move Down
    Private Sub btnAddMoveRoute2_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute2.Click
        AddMoveRouteCommand(2)
    End Sub

    'Move Left
    Private Sub btnAddMoveRoute3_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute3.Click
        AddMoveRouteCommand(3)
    End Sub

    'Move Right
    Private Sub btnAddMoveRoute4_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute4.Click
        AddMoveRouteCommand(4)
    End Sub

    'Move Randomly
    Private Sub btnAddMoveRoute5_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute5.Click
        AddMoveRouteCommand(6)
    End Sub

    'Move to Player
    Private Sub btnAddMoveRoute6_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute6.Click
        AddMoveRouteCommand(6)
    End Sub

    'Move from Player
    Private Sub btnAddMoveRoute7_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute7.Click
        AddMoveRouteCommand(7)
    End Sub

    'Step Forward
    Private Sub btnAddMoveRoute8_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute8.Click
        AddMoveRouteCommand(8)
    End Sub

    'Step Back
    Private Sub btnAddMoveRoute9_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute9.Click
        AddMoveRouteCommand(9)
    End Sub

    'Wait 100ms
    Private Sub btnAddMoveRoute10_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute10.Click
        AddMoveRouteCommand(10)
    End Sub

    'Wait 500ms
    Private Sub btnAddMoveRoute11_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute11.Click
        AddMoveRouteCommand(11)
    End Sub

    'Wait 1000ms
    Private Sub btnAddMoveRoute12_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute12.Click
        AddMoveRouteCommand(12)
    End Sub

    'Turn Up
    Private Sub btnAddMoveRoute13_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute13.Click
        AddMoveRouteCommand(13)
    End Sub

    'Turn Down
    Private Sub btnAddMoveRoute14_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute14.Click
        AddMoveRouteCommand(14)
    End Sub

    'Turn Left
    Private Sub btnAddMoveRoute15_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute15.Click
        AddMoveRouteCommand(15)
    End Sub

    'Turn Right
    Private Sub btnAddMoveRoute16_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute16.Click
        AddMoveRouteCommand(16)
    End Sub

    'Turn 90 dg Right
    Private Sub btnAddMoveRoute17_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute17.Click
        AddMoveRouteCommand(17)
    End Sub

    'Turn 90 dg Left
    Private Sub btnAddMoveRoute18_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute18.Click
        AddMoveRouteCommand(18)
    End Sub

    'Turn 180 dg
    Private Sub btnAddMoveRoute19_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute19.Click
        AddMoveRouteCommand(19)
    End Sub

    'Turn Randomly
    Private Sub btnAddMoveRoute20_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute20.Click
        AddMoveRouteCommand(20)
    End Sub

    'Turn to Player
    Private Sub btnAddMoveRoute21_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute21.Click
        AddMoveRouteCommand(21)
    End Sub

    'Turn from Player
    Private Sub btnAddMoveRoute22_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute22.Click
        AddMoveRouteCommand(22)
    End Sub

    'Set Speed 8x Slower
    Private Sub btnAddMoveRoute23_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute23.Click
        AddMoveRouteCommand(23)
    End Sub

    'Set Speed 4x Slower
    Private Sub btnAddMoveRoute24_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute24.Click
        AddMoveRouteCommand(24)
    End Sub

    'Set Speed 2x Slower
    Private Sub btnAddMoveRoute25_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute25.Click
        AddMoveRouteCommand(25)
    End Sub

    'Set Speed to Normal
    Private Sub btnAddMoveRoute26_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute26.Click
        AddMoveRouteCommand(26)
    End Sub

    'Set Speed 2x Faster
    Private Sub btnAddMoveRoute27_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute27.Click
        AddMoveRouteCommand(27)
    End Sub

    'Set Speed 4x Faster
    Private Sub btnAddMoveRoute28_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute28.Click
        AddMoveRouteCommand(28)
    End Sub

    'Set Frequency to Lowest
    Private Sub btnAddMoveRoute29_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute29.Click
        AddMoveRouteCommand(29)
    End Sub

    'Set Frequency to Lower
    Private Sub btnAddMoveRoute30_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute30.Click
        AddMoveRouteCommand(30)
    End Sub

    'Set Frequency to Normal
    Private Sub btnAddMoveRoute31_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute31.Click
        AddMoveRouteCommand(31)
    End Sub

    'Set Frequency to Higher
    Private Sub btnAddMoveRoute32_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute32.Click
        AddMoveRouteCommand(32)
    End Sub

    'Set Frequency to Highest
    Private Sub btnAddMoveRoute33_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute33.Click
        AddMoveRouteCommand(33)
    End Sub

    'Walk Animation On
    Private Sub btnAddMoveRoute34_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute34.Click
        AddMoveRouteCommand(34)
    End Sub

    'Walk Animation Off
    Private Sub btnAddMoveRoute35_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute35.Click
        AddMoveRouteCommand(35)
    End Sub

    'Fixed Direction On
    Private Sub btnAddMoveRoute36_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute36.Click
        AddMoveRouteCommand(36)
    End Sub

    'Fixed Direction Off
    Private Sub btnAddMoveRoute37_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute37.Click
        AddMoveRouteCommand(37)
    End Sub

    'Walkthrough On
    Private Sub btnAddMoveRoute38_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute38.Click
        AddMoveRouteCommand(28)
    End Sub

    'Walkthrough Off
    Private Sub btnAddMoveRoute39_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute39.Click
        AddMoveRouteCommand(39)
    End Sub

    'Position Below Player
    Private Sub btnAddMoveRoute40_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute40.Click
        AddMoveRouteCommand(40)
    End Sub

    'Position Same as Player
    Private Sub btnAddMoveRoute41_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute41.Click
        AddMoveRouteCommand(41)
    End Sub

    'Position Above Player
    Private Sub btnAddMoveRoute42_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute42.Click
        AddMoveRouteCommand(42)
    End Sub

    'Set Graphic
    Private Sub btnAddMoveRoute43_Click(sender As Object, e As EventArgs) Handles btnAddMoveRoute43.Click
        fraGraphic.Width = 841
        fraGraphic.Height = 585
        fraGraphic.Visible = True
        GraphicSelType = 1
    End Sub

#End Region


End Class