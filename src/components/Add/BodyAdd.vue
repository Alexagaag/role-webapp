<template>
<b-card style="width:650px;margin-top:15px">
<b-form style="width:600px" @submit="onSubmit" @reset="onReset">
    <b-form-group
      id="input-group-1"
      label="Nombre Empleado:"
      label-for="input-1"
    >
      <b-form-input
        id="input-1"
        v-model="Permiso.nombreEmpleado"
        required
        placeholder="Intoduzca el nombre del empleado"
      ></b-form-input>
    </b-form-group>

    <b-form-group
     id="input-group-2" 
    label="Apellidos del empleado:" 
    label-for="input-2">
      <b-form-input
        id="input-2"
        v-model="Permiso.apellidosEmpleado" 
        required
        placeholder="Introduzca los apellido del empleado"
      ></b-form-input>
    </b-form-group>

    <b-form-group
     id="input-group-3" 
    label="Tipo de permiso:" 
    label-for="input-3">
      <b-form-input
        id="input-3"
        v-model="Permiso.tipoPermiso" 
        type="number"
        required
        placeholder="Inntroduzca el código del tipo de permiso"
      ></b-form-input>
    </b-form-group>

        <b-form-group
     id="input-group-4" 
    label="Fecha permiso:" 
    label-for="input-4">
      <b-form-input
        id="input-4"
        v-model="Permiso.fechaPermiso" 
        required
        type="date"
      ></b-form-input>
    </b-form-group>


    <b-button style="margin-left:5%" type="submit" variant="primary">Registrar Permiso</b-button>
    <b-button style="margin-left:50%" type="reset" variant="danger">Limpiar</b-button>
  </b-form>
</b-card>
</template>

<script>
import axios from 'axios'



export default {
  name: "BodyAdd",
  props:{
    Permiso: {type:Object}
      
  }
  ,
  methods: {
      onSubmit(evt) {
        evt.preventDefault()
        var data = {
            id : this.Permiso.id,
            nombreEmpleado : this.Permiso.nombreEmpleado,
            apellidosEmpleado : this.Permiso.apellidosEmpleado,
            tipoPermiso : this.Permiso.tipoPermiso,
            fechaPermiso : this.Permiso.fechaPermiso
        }
        axios.post("https://localhost:44398/Permisos/Save",data ).then(
            alert("Permiso registrado satisfactoriamente.")
        ).catch()
         },
      onReset(evt) {
        evt.preventDefault()
        this.Permiso.nombreEmpleado = ''
        this.Permiso.id = 0
        this.Permiso.apellidosEmpleado = ''
        this.Permiso.tipoPermiso = null
        this.Permiso.fechaPermiso = null
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
    },
}
</script>