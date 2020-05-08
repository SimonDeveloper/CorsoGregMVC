Namespace ViewModel
	Public Class ApplicativoViewModel

		Private _id As Integer
		Public Property id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				_id = value
			End Set
		End Property

		Private _idCliente As Integer?
		Public Property idCliente As Integer?
			Get
				Return _idCliente
			End Get
			Set(value As Integer?)
				_idCliente = value
			End Set
		End Property

		Private _iddirettiva As Integer?
		Public Property iddirettiva As Integer?
			Get
				Return _iddirettiva
			End Get
			Set(value As Integer?)
				_iddirettiva = value
			End Set
		End Property

		Private _DescrizioneProgramma As String
		Public Property DescrizioneProgramma As String
			Get
				Return _DescrizioneProgramma
			End Get
			Set(value As String)
				_DescrizioneProgramma = value
			End Set
		End Property

		Private _subdirectory As String
		Public Property subdirectory As String
			Get
				Return _subdirectory
			End Get
			Set(value As String)
				_subdirectory = value
			End Set
		End Property

		Private _DescrizioneAssembly As String
		Public Property DescrizioneAssembly As String
			Get
				Return _DescrizioneAssembly
			End Get
			Set(value As String)
				_DescrizioneAssembly = value
			End Set
		End Property

		Private _annullato As Integer?
		Public Property annullato As Integer?
			Get
				Return _annullato
			End Get
			Set(value As Integer?)
				_annullato = value
			End Set
		End Property

		Private _Note As String
		Public Property Note As String
			Get
				Return _Note
			End Get
			Set(value As String)
				_Note = value
			End Set
		End Property

		Private _old_collegamento As String
		Public Property old_collegamento As String
			Get
				Return _old_collegamento
			End Get
			Set(value As String)
				_old_collegamento = value
			End Set
		End Property

		Private _visibile As Integer?
		Public Property visibile As Integer?
			Get
				Return _visibile
			End Get
			Set(value As Integer?)
				_visibile = value
			End Set
		End Property

	End Class
	Public Class Menu_Procedure

		Private _id As Integer
		Public Property id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				_id = value
			End Set
		End Property

		Private _idCliente As Integer?
		Public Property idCliente As Integer?
			Get
				Return _idCliente
			End Get
			Set(value As Integer?)
				_idCliente = value
			End Set
		End Property

		Private _iddirettiva As Integer?
		Public Property iddirettiva As Integer?
			Get
				Return _iddirettiva
			End Get
			Set(value As Integer?)
				_iddirettiva = value
			End Set
		End Property

		Private _DescrizioneProgramma As String
		Public Property DescrizioneProgramma As String
			Get
				Return _DescrizioneProgramma
			End Get
			Set(value As String)
				_DescrizioneProgramma = value
			End Set
		End Property

		Private _subdirectory As String
		Public Property subdirectory As String
			Get
				Return _subdirectory
			End Get
			Set(value As String)
				_subdirectory = value
			End Set
		End Property

		Private _DescrizioneAssembly As String
		Public Property DescrizioneAssembly As String
			Get
				Return _DescrizioneAssembly
			End Get
			Set(value As String)
				_DescrizioneAssembly = value
			End Set
		End Property

		Private _annullato As Integer?
		Public Property annullato As Integer?
			Get
				Return _annullato
			End Get
			Set(value As Integer?)
				_annullato = value
			End Set
		End Property

		Private _Note As String
		Public Property Note As String
			Get
				Return _Note
			End Get
			Set(value As String)
				_Note = value
			End Set
		End Property

		Private _old_collegamento As String
		Public Property old_collegamento As String
			Get
				Return _old_collegamento
			End Get
			Set(value As String)
				_old_collegamento = value
			End Set
		End Property

		Private _visibile As Integer?
		Public Property visibile As Integer?
			Get
				Return _visibile
			End Get
			Set(value As Integer?)
				_visibile = value
			End Set
		End Property

	End Class
End Namespace
