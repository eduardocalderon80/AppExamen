export interface Usuario {
  usu_id: number,
  usu_nombre: string,
  usu_apellido: string,

  usu_email: string,
  cod_rol: number,
  usu_estado: number
}

export interface MyResponse {
  Success: number,
  Data: any,
  Message: string
}
