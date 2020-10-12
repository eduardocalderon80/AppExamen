import { Component, Inject, ViewChild, ElementRef } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { UsuarioService } from '../service/usuario.service';
import { Usuario } from '../interfaces';
import { Observable } from 'rxjs/Observable'
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html'
})

export class UsuarioComponent {
  public lstUsuario: Observable<Usuario[]>;

  nombreControl = new FormControl('')
  apellidoControl = new FormControl('')
  emailControl = new FormControl('')

  //// APLICANDO VIEWCHILD Y ELEMENTEREF ; PARA PODER ACCEDER AL DOM
  //@ViewChild('text') text: ElementRef

  //// APLICANDO INJECCION DE DEPENDENCIA EN EL CONSTRUCTOR; EJEMPLO EL SERVICIO CHATSERVICE
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
    protected usuarioService: UsuarioService
  ) {
    this.GetInfo()
  }

  public GetInfo() {
    this.lstUsuario = this.usuarioService.()
  }

  public NuevoUsuario() {
    //console.log('TEXTO CONTROL:' + this.textControl.value)
    this.usuarioService.Add(this.nombreControl.value, this.apellidoControl.value, this.emailControl.value);

    setTimeout(() => {
      this.GetInfo()
    }, 300);

    this.nombreControl.setValue('')
    this.apellidoControl.setValue('')
    this.emailControl.setValue('')
    

  }
}

