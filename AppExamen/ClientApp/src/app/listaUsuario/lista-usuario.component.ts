import { Component, Input } from '@angular/core';
import { Usuario } from '../interfaces';

@Component({
  selector: 'app-listaUsuario',
  templateUrl: './lista-usuario.component.html'
})

export class ListaUsuarioComponent {
  @Input() oListaUsuario: Usuario;
}

//interface Message {
//  Id: number,
//  Name: string,
//  Texto: string
//}
