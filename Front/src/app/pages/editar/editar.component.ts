import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.service';
import {Router, ActivatedRoute, Params} from '@angular/router';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.css']
})
export class EditarComponent implements OnInit {

  editavel: any;

  constructor(private route: ActivatedRoute, private funcionarioService: FuncionarioService) {
  }

  ngOnInit(): void {
    let id = this.route.snapshot.paramMap.get('id');
    this.funcionarioService.getFuncio(id).subscribe((res:any) =>{
      this.editavel = res
      console.log("meus dados ", res)
    })
  }

}

