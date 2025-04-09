<h1>Unity_RayCastEx</h1>
<p>Exemplo de Raycast, feito no Unity</p><br>
<p>No Unity, criamos uma cena para fazer o teste do Raycast.</p>
<p>Para a criação do cenario, para que posamos realizar os testes, utilizamos 4 GameObjects Plane (4 objetos planos).</p>

![Imagem: Cena](https://github.com/user-attachments/assets/f7a9e976-827a-4149-8c09-0cf21cf42436)
<p>No centro da cena, colocamos um cubo, que iremos utilizar mais adiante para disparar o raycast.</p>
<br>
<h2>No código criamos 3 funções para disparar o raycast.</h2>
<p>O primeiro é ativado através do click do botão esquerdo do mouse. Ele "atira" o raycast a partir da posição do mouse na tela.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click Mouse Raycast](https://github.com/user-attachments/assets/fc0c4e85-3f0d-4ec3-8550-c07a9376703e)
<br><br>
<p>O segundo é ativado precionando a tecla "E". Ele dispara o raycast a partir do centro do objeto cubo, que é um prefab da cena.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click "E" Raycast](https://github.com/user-attachments/assets/68876038-06cf-4cff-bff6-d8c341738d7b)
<br><br>
<p>E o ultimo, é ativado precionando a tecla "Q", do teclado. Ele "atira" o raycast a partir do centro da camera.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click "Q" Raycast](https://github.com/user-attachments/assets/e3585fc9-b0fa-45f7-b0ba-089a049cee8f)
<br><br>
<h2>Todas essas funções são decorentes do método "Atirar", que é responsavel por definir a origem e a direção do raio, e também ver se ele está colidindo com algo.</h2>

![Imagem: Método Atirar](https://github.com/user-attachments/assets/5263e50a-60fd-4cd1-b87a-319c5c898af0)
<br><br>
<h2>Agora, acompanhe o vídeo mostrando as funções do raycast.</h2>

https://github.com/user-attachments/assets/1c077180-3047-47bc-8319-f31ec6c2c1c8
