Use CadastroFuncionario
Go

If Not Exists (Select Top 1 1 From Habilidade (Nolock)) 
Begin
	Insert Into Habilidade
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

If Not Exists (Select Top 1 1 From Sexo (Nolock)) 
Begin
	Insert Into Sexo
	(
		Descricao
	)
	Values
	 ('Masculino')
	,('Femenino')
	,('Outro')
End
Go
