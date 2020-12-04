Use CadastroFuncionario
Go

If Not Exists (Select Top 1 1 From GastoTipo (Nolock)) 
Begin
	Insert Into GastoTipo
	(
		Descricao
	)
	Values
	 ('CSharp')
	,('Java')
	,('Angular')
	,('SQL')
	,('ASP')
End
Go
