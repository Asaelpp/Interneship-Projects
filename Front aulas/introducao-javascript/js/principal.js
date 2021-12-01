var title = document.querySelector(".title");

title.textContent = "Aparecida Nutricionista"

var pacientes= document.querySelectorAll(".paciente")

for (let i = 0; i < pacientes.length; i++) {
    var paciente = pacientes[i];

    var tdPeso = paciente.querySelector(".info-peso")

    var peso = tdPeso.textContent;

    var tdAltura = paciente.querySelector(".info-altura")

    var altura = tdAltura.textContent;

    var tdImc = paciente.querySelector(".info-imc")

    var pesoValido = true;

    var alturaValida = true;

    if (peso < 0 || peso >= 1000) {

        console.log("Peso Inválido");
        pesoValido = false;
        tdImc.textContent = "Peso Inválido"
    }

    if (altura < 0 || altura >= 4.00) {

        console.log("Altura Inválido");
        alturaValida = false;
        tdImc.textContent = "Altura Inválida";
    }

    if (pesoValido && alturaValida) {
        var imc = peso / (altura * altura);

        tdImc.textContent = imc.toFixed(2);

    }

}




