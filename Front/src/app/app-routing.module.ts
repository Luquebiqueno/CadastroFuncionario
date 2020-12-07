import { NgModule } from '@angular/core';
import { HomeComponent } from './pages/home/home.component'
import { EditarComponent } from './pages/editar/editar.component'
import { RelatorioComponent } from './pages/relatorio/relatorio.component'
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '',           component: HomeComponent },
  { path: 'relatorio/:id',    component: EditarComponent },
  { path: 'relatorio', component: RelatorioComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
