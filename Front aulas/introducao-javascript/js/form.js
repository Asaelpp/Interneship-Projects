
var botaoAdicionar = document.querySelector("#adicionar-paciente");
botaoAdicionar.addEventListener("click", function (event) {
    event.preventDefault();

    var form = document.querySelector("#form-adiciona");
    //Extraindo info dos pacientes



    var paciente = obtemFormPaciente(form);
    
    console.log(paciente);

    //criar a tr e td para o paciente



    var erros = validaPaciente(paciente);

    console.log("Paciente Inválido");

    if (erros.length > 0){
        exibeMensagensDeErro(erros);
        return;
    }


    //tabela


addPaciente(paciente);


    form.reset();

    document.querySelector("#mensagem-erro");

    ul.innerHTML = "";
});

function addPaciente(paciente){
    var pacienteTr = MontaTr(paciente);
    var tabela = document.querySelector("#tabela-pacientes");
    tabela.appendChild(pacienteTr);
}


function exibeMensagensDeErro(erros){
    var ul = document.querySelector("#mensagem-erro");

    ul.innerHTML = "";

    erros.forEach(function(erro){
        var li = document.createElement("li");
        li.textContent = erro;
        ul.appendChild(li);
    });
}

function obtemFormPaciente(form) {

    var paciente = {
        nome: form.nome.value,
        peso: form.peso.value,
        altura: form.altura.value,
        gordura: form.gordura.value,
        imc: calculaImc(form.peso.value, form.altura.value)
    }

    return paciente;
}

function MontaTr(paciente){

    var pacienteTr = document.createElement("tr");

    pacienteTr.classList.add("paciente");

    pacienteTr.appendChild(MontaTd(paciente.nome, "info-nome"));
    pacienteTr.appendChild(MontaTd(paciente.peso, "info-peso"));
    pacienteTr.appendChild(MontaTd(paciente.altura, "info-altura"));
    pacienteTr.appendChild(MontaTd(paciente.gordura, "info-gordura"));
    pacienteTr.appendChild(MontaTd(paciente.imc, "info-imc"));

    return pacienteTr;

}

function MontaTd(dado,classe){
    var td = document.createElement("td")
    td.textContent = dado;
    td.classList.add(classe);

    return td;
}


function validaPaciente(paciente) {

    var erros = [];

    if (!validaPeso(paciente.peso)) {
        erros.push("Peso é inválido");
    }

    if (!validaAltura(paciente.altura)) {
        erros.push("Altura é inválida");
    }

    if (paciente.nome.length == 0){
        erros.push("O nome não pode ficar em Branco");
    }

    if (paciente.gordura.length == 0){
        erros.push("A gordura não pode ficar em Branco");
    }

    if (paciente.peso.length == 0){
        erros.push("O peso não pode ser em branco");
    }

    if (paciente.altura.length == 0){
        erros.push("Altura não pode ficar em branco");
    }

    return erros;
}