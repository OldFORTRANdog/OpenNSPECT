'********************************************************************************************************
'File Name: XmlPollutantItems.vb 
'Description: Class for handling pollutant items xml
'********************************************************************************************************
'The contents of this file are subject to the Mozilla Public License Version 1.1 (the "License"); 
'you may not use this file except in compliance with the License. You may obtain a copy of the License at 
'http://www.mozilla.org/MPL/ 
'Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
'ANY KIND, either express or implied. See the License for the specificlanguage governing rights and 
'limitations under the License. 
'
'Note: This code was converted from the vb6 NSPECT ArcGIS extension and so bears many of the old comments
'in the files where it was possible to leave them.
'
'Contributor(s): (Open source contributors should list themselves and their modifications here). 
'Oct 20, 2010:  Allen Anselmo allen.anselmo@gmail.com - 
'               Added licensing and comments to code
Imports System.Xml

Namespace Xml

    Public Class PollutantItems
        Inherits Base
        Implements IEnumerable
        ' *************************************************************************************
        ' *  Perot Systems Government Services
        ' *  Contact: Ed Dempsey - ed.dempsey@noaa.gov
        ' *  XmlPollutantItems
        ' *************************************************************************************
        ' *  Description: Xml Wrapper for use a pollutants (the whole group) in the frmPrj Pollutants Tab
        ' *
        ' *  Called By:
        ' *************************************************************************************
        ' *  Subs:
        ' *
        ' *
        ' *  Misc:
        ' *  Acknowledgements: Dave Grundgeiger       daveg@tarasoftware.com
        ' *                    Patrick Escarcega      patrick@vbguru.net
        ' *
        ' *************************************************************************************

        Private Const NODE_NAME As String = "Pollutants"

        Private m_colItems As ArrayList

        Public ReadOnly Property NodeName() As String
            Get
                'Retrieve the name of the element that this class wraps.

                NodeName = NODE_NAME

            End Get
        End Property

        Public ReadOnly Property Count() As Integer
            Get
                'Return the count of order items.

                Count = m_colItems.Count()

            End Get
        End Property

        Public Property Item(ByVal Index As Integer) As PollutantItem
            Get
                'Get the order item at the given index.
                Item = m_colItems.Item(Index)
            End Get
            Set(ByVal Value As PollutantItem)
                m_colItems.Add(Value)
            End Set
        End Property

        Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Try
                GetEnumerator = m_colItems.GetEnumerator
            Catch ex As Exception
                HandleError(ex)
                GetEnumerator = Nothing
            End Try
        End Function

        Public Overrides Function CreateNode(Optional ByRef Parent As XmlNode = Nothing) As XmlNode
            Try
                'Return an Xml DOM node that represents this class's properties. If a
                'parent DOM node is passed in, then the returned node is also added as a
                'child node of the parent.

                Dim node As XmlNode
                Dim dom As XmlDocument

                'If no parent was passed in, then create a DOM and document element.
                If Parent Is Nothing Then
                    dom = New XmlDocument
                    dom.LoadXml("<" & NODE_NAME & "/>")
                    node = dom.DocumentElement
                    'Otherwise use passed-in parent.
                Else
                    dom = Parent.OwnerDocument
                    node = dom.CreateElement(NODE_NAME)
                    Parent.AppendChild(node)
                End If

                Dim MgmtScen As PollutantItem

                For Each MgmtScen In m_colItems
                    node.AppendChild(dom.CreateTextNode(vbNewLine & vbTab))
                    MgmtScen.CreateNode(node)
                Next MgmtScen

                node.AppendChild(dom.CreateTextNode(vbNewLine & vbTab))

                MgmtScen = Nothing

                'Return the created node
                CreateNode = node

            Catch ex As Exception
                HandleError(ex)
                CreateNode = Nothing
            End Try
        End Function

        Public Overrides Sub LoadNode(ByRef node As XmlNode)
            Try
                'Set this class's properties based on the data found in the
                'given node.

                'Ensure that a valid node was passed in.
                If node Is Nothing Then Return

                Dim MgmtScen As PollutantItem
                Dim nodes As XmlNodeList
                Dim MgmtNode As XmlNode

                MgmtScen = New PollutantItem
                m_colItems = New ArrayList

                nodes = node.SelectNodes(MgmtScen.NodeName)
                For Each MgmtNode In nodes
                    MgmtScen = New PollutantItem
                    MgmtScen.LoadNode(MgmtNode)
                    m_colItems.Add(MgmtScen)
                Next MgmtNode

            Catch ex As Exception
                HandleError(ex)
            End Try
        End Sub

        Public Sub New()
            Try
                m_colItems = New ArrayList
            Catch ex As Exception
                HandleError(ex)
            End Try
        End Sub

        Public Sub Add(ByVal MgmtScen As PollutantItem)
            'Add a mgmt scen item.
            Try

                m_colItems.Add(MgmtScen)

            Catch ex As Exception
                HandleError(ex)
            End Try
        End Sub

        Public Sub Remove(ByVal Index As Integer)
            'Remove an order item.
            Try

                m_colItems.Remove(Index)

            Catch ex As Exception
                HandleError(ex)
            End Try
        End Sub

        'End of code to support repeating <OrderItem> elements.
        '*************************************************************************
    End Class
End Namespace