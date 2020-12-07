import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private funcionarioService: FuncionarioService) { }

  ngOnInit(): void {
  }

  onSubmit(formData:any):void{
    this.funcionarioService.createFuncionario(formData.value).subscribe((res:any)=>{
    })
  }

}
