import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.service';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.css']
})
export class RelatorioComponent implements OnInit {

  public funcionario: any;

  constructor(private funcionarioService: FuncionarioService) { }

  ngOnInit(): void {
    this.getFuncionario();
  }

  getFuncionario(){
    this.funcionarioService.getFuncionario().subscribe((response:any)=> {
        this.funcionario = response
      }
    );  
  }
}

