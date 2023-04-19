var $btn = document.getElementById('btn');
var $addTask = document.querySelector('#addTask');
var $ul = document.querySelector('.uls');
var $li = $ul.querySelectorAll('li');

var $timeNow =  document.getElementById('timeNow');

var date = new Date().toLocaleDateString();
var time = new Date().toLocaleTimeString('pt-BR',{hour:'numeric', minute:'numeric'} );
$timeNow.innerHTML = `${date} ${time}`


//$addTask.addEventListener('keyup', function(e){
//    if(e.keyCode === 13){
//        newTask();
//    }
//});


for(var i =0;i<$li.length;i++){
    addEvent($li[i]);
}

function taskFinish(){
    // debugger
    this.classList.toggle('task-finish');
}


//function newTask(){
//    // debugger
//    if($addTask.value != ""){
        
       
//        var li = document.createElement('li');
//        var div = document.createElement('div');
//        var $p = document.createElement('p');
//        var text = document.createTextNode($addTask.value);
//        li.appendChild(div);
//        div.classList.add("texto");
//        div.appendChild($p);
//        $p.appendChild(text);
//        $ul.appendChild(li);
        
//        $addTask.value = "";
//        $addTask.focus();
//        addEvent(li);
//    }
//    else{
//        $addTask.value = "";
//        $addTask.focus();
//    }
    
//}
function addEvent(li){
    li.addEventListener('click', taskFinish);
}


