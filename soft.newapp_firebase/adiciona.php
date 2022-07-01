<?php
include("config.php");
include("firebaseRDB.php");
$db = new firebaseRDB($databaseURL);
?>


<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="Bootstrap contributors">
  <meta name="generator" content="0.98.0">
  <link rel="icon" type="image/png" href="../images/amaury.png">
  <title>Firebase - Amaury Huerb</title>
  <link href="assets/css/bootstrap.min.css" rel="stylesheet">
  <link href="features.css" rel="stylesheet">
  <!--Utilizar este modelo para definir o CSS-->
  <link href="assets/css/aparence.css" rel="stylesheet" id="bootstrap-css"></style>
</head>

<body>
  <div align="right">
    <!--Definições de Botão-Alterna modo-->
      Background : <i class="fa fa-moon-o" aria-hidden="true"></i> <i class="fa fa-sun-o" aria-hidden="true"></i>
      <script src="https://use.fontawesome.com/62e43a72a9.js"></script>
      <!--script src="assets/js/62e43a72a9.js"></script-->
      <button type="button" class="btn btn-outline-secondary fa fa-sliders" id="yesBtn" onclick="myFunction()"></button>
      <script>
          function myFunction() {
          var element = document.body;
          element.classList.toggle("dark-mode");
          }
      </script>
  </div>

  <main>
    <div class="container">
      <br>
      <h2 class="pb-2 border-bottom">TABELA - FIREBASE</h2>
      <br>

      <form method="post" action="action_add.php">
        <table border="0" width="500">
            <tr>
              <td>Title</td>
              <td>:</td>
              <td><input type="text" name="title" class="form-control" id="imagem" aria-describedby="imagem" placeholder=""></td>
            <tr>
              <td>Thumbnail</td>
              <td>:</td>
              <td><input type="text" name="thumbnail" class="form-control" id="imagem" aria-describedby="imagem" placeholder=""></td>
            </tr>
            <tr>
              <td>Year</td>
              <td>:</td>
              <td><input type="text" name="year" class="form-control" id="imagem" aria-describedby="imagem" placeholder=""></td>
            </tr>
            <tr>
              <td>Rating</td>
              <td>:</td>
              <td><input type="text" name="rating" class="form-control" id="imagem" aria-describedby="imagem" placeholder=""></td>
            </tr>
            <tr>
              <td><input type="submit" value="SAVE"></td>
            </tr>
        </table>
      </form>

      <!--td><input type="text" class="form-control" id="imagem" aria-describedby="imagem" placeholder=""></td-->

 
    </div>
  </div>
    
  </main>
  <script src="assets/js/bootstrap.bundle.min.js"></script>
</body>
</html>


<!--Stylo Inicial-->
<style>
  body { padding: 25px; background-color: #4b5154; color: white; font-size: 15px;}
  .dark-mode { background-color: white; color: black;}
  .bd-placeholder-img { font-size: 1.125rem; text-anchor: middle; -webkit-user-select: none; -moz-user-select: none; user-select: none; }
  @media (min-width: 768px) { .bd-placeholder-img-lg { font-size: 3.5rem; } }
  .b-example-divider { height: 3rem; background-color: rgba(0, 0, 0, .1); border: solid rgba(0, 0, 0, .15); border-width: 1px 0;
    box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15); }
  .b-example-vr { flex-shrink: 0; width: 1.5rem; height: 100vh; } .bi { vertical-align: -.125em;  fill: currentColor; }
  .nav-scroller { position: relative; z-index: 2; height: 2.75rem; overflow-y: hidden;}
  .nav-scroller .nav { display: flex; flex-wrap: nowrap; padding-bottom: 1rem; margin-top: -1px; overflow-x: auto; text-align: center; white-space: nowrap; -webkit-overflow-scrolling: touch; }
</style>
