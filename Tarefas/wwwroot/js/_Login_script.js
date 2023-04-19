//var $input = document.querySelectorAll('.inputs');

//$($input).keyup(function (e) {
//    if (e.which === 13) {

//        var index = $($input).index(this) + 1;

//        $($input).eq(index).focus();
//    }
//});

//var $cadastro = document.getElementById('cadastro');
//var $loginCard = document.getElementById('backLogin');
//$cadastro.addEventListener('click', cadastro);
//$loginCard.addEventListener('click', login);

//var $login = document.getElementById('login');
//var $signUp = document.getElementById('signUp');

//$signUp.addEventListener('submit', e => {
//    e.preventDefault();

//    validate();
//    // alertSignUp();
//})


//var $btnEntre = document.getElementById('btn');
//var $signSubmit = document.getElementById('signSubmit');
//$btnEntre.addEventListener('click', alertSuccess);


//function cadastro() {
//    document.getElementById('login').style.display = "none";
//    document.getElementById('form_sing_up').style.display = "flex";

//}
//function login() {
//    document.getElementById('login').style.display = "flex";
//    document.getElementById('form_sing_up').style.display = "none";
//}

//function alertSuccess() {
//    Swal.fire({
//        width: 300,
//        height: 150,
//        title: 'Perfeito!',
//        text: 'Você está logado!',
//        icon: 'success',
//        showCancelButton: true
//    }).then((result) => {
//        if (result.isDismissed) {
//            Swal.fire({
//                width: 300,
//                height: 150,
//                title: 'Cancelado',
//                text: 'Você não está logado!',
//                icon: 'error',
//            });

//        }
//    })
//}

//function alertSignUp() {
//    Swal.fire({
//        width: 300,
//        height: 150,
//        title: 'Perfeito!',
//        text: 'Cadastrado com sucesso!',
//        icon: 'success',

//    }).then((result) => {
//        if (result.isConfirmed) {
//            login();

//        }
//        // verificar opções do resultado de click no alerta 
//        // console.log(result);
//    });

//}
//var $locker = document.getElementById('locker');
//var $checked = document.getElementById('chk');
//$checked.addEventListener('click', lockOpened)
//function lockOpened() {
//    if ($checked.checked === true) {
//        $locker.classList.remove("fa-lock-open");
//        $locker.classList.add("fa-lock");
//    }
//    else {
//        $locker.classList.add("fa-lock-open");
//        $locker.classList.remove("fa-lock");
//    }
//}




//var $name = document.getElementById('firstName');
//var $lastName = document.getElementById('lastName');
//var $userName = document.getElementById('userName');
//var $email = document.getElementById('email');
//var $phone = document.getElementById('phone');

//function validate() {

//    if ($name.value == "" || $name.value == null) {
//        var name = $name.name = "Nome";
//        alertPreencher(name);
//    }
//    else if ($lastName.value == "" || $lastName.value == null) {
//        var last = $lastName.name = "Sobrenome";
//        alertPreencher(last);
//    }
//    else if ($userName.value == "" || $userName.value == null) {
//        var user = $userName.name = "Usuário";
//        alertPreencher(user);
//    }
//    else if ($email.value == "" || $email.value == null) {
//        var email = $email.name = "Email";
//        alertPreencher(email);
//    }
//    else if ($phone.value == "" || $phone.value == null) {
//        var phone = $phone.name = "Telefone";
//        alertPreencher(phone);
//    }
//    else {
//        alertSignUp();
//    }

//}

//function alertPreencher(last) {
//    Swal.fire({
//        width: 300,
//        height: 150,
//        title: 'Ops!',
//        html: 'O campo <b>' + last + '</b> deve ser preenchido',
//        icon: 'warning',

//    });
//}




