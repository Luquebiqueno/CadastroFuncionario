import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {

  url= environment.host + 'Funcionario'

  constructor(private http: HttpClient) { }

  public getFuncionario(): any{
    return this.http.get<any>(this.url);
  }
  public getFuncio(id:any): any{
    return this.http.get<any>(this.url + '/' + id);
  }
  public createFuncionario(data:any){
    return this.http.post(this.url, data);
  }
}
