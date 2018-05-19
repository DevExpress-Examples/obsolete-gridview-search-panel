@Imports DevExpress.Data.Filtering
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gv"
    
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.CustomActionRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialCustom"}
    
            settings.KeyFieldName = "ID"
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
    
            settings.Columns.Add("ID")
            settings.Columns.Add("Text")
            
            settings.Settings.ShowFilterBar = GridViewStatusBarMode.Auto
    
            settings.BeforeGetCallbackResult = _
                Sub(s, e)
                        If ViewData("SearchString") IsNot Nothing Then
                            Dim searchString As String = ViewData("SearchString").ToString()
                            Dim criteria = New FunctionOperator(FunctionOperatorType.Contains, New OperandProperty("Text"), searchString)

                            Dim gridView = CType(s, MVCxGridView)
                            gridView.FilterExpression = criteria.ToString()
                        End If
                End Sub
    End Sub).Bind(Model).GetHtml()