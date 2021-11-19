const iniciar = async () => {
    const dadosEscola = document.getElementById("dadosEscola");
    const response = await fetch('/Escola');
    const result = await response.json();
    dadosEscola.innerHTML = result.dadosEscola;
};

document.addEventListener('DOMContentLoaded', iniciar);