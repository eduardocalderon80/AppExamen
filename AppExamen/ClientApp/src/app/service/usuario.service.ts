import { Injectable, Inject } from '@angular/core'
import { Usuario, MyResponse } from '../interfaces'
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable } from 'rxjs/Observable'

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}

@Injectable({
  providedIn: 'root'
})


export class UsuarioService {
  public algo: string = "Hola mundo service"
  baseUrl: string

  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl
  }

  public GetMessage(): Observable<Usuario[]> {

    return this.http.get<Usuario[]>(this.baseUrl + "api/Usuario/Usuarios")
  }

  public Add(nombre, apellido, email) {
    this.http.post<MyResponse>(this.baseUrl + "api/Usuario/Add", { 'usu_nombre': nombre, 'usu_apellido': apellido, 'usu_email': email }, httpOptions)
      .subscribe(result => {
        console.log(result)
      }, error => console.error(error))
  }
}
