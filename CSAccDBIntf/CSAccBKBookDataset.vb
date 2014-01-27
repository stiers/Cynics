Namespace CSAccBKBookDatasetTableAdapters
    Partial Class TRN_BKTRANTableAdapter
        Public Sub SetCommandsTransaction(ByVal InConnection As System.Data.SqlClient.SqlConnection, ByVal InTransaction As System.Data.SqlClient.SqlTransaction)
            Adapter.UpdateCommand.Connection = InConnection
            Adapter.InsertCommand.Connection = InConnection
            Adapter.DeleteCommand.Connection = InConnection
            Adapter.UpdateCommand.Transaction = InTransaction
            Adapter.DeleteCommand.Transaction = InTransaction
            Adapter.InsertCommand.Transaction = InTransaction
        End Sub
    End Class

    Partial Class TRN_BKTRANDTableAdapter
        Public Sub SetCommandsTransaction(ByVal InConnection As System.Data.SqlClient.SqlConnection, ByVal InTransaction As System.Data.SqlClient.SqlTransaction)
            Adapter.UpdateCommand.Connection = InConnection
            Adapter.InsertCommand.Connection = InConnection
            Adapter.DeleteCommand.Connection = InConnection
            Adapter.UpdateCommand.Transaction = InTransaction
            Adapter.DeleteCommand.Transaction = InTransaction
            Adapter.InsertCommand.Transaction = InTransaction
        End Sub
    End Class
End Namespace
Partial Class CSAccBKBookDataset
End Class
