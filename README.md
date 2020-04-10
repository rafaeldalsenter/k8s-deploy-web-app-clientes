# kubernetes-web-app-clientes
🛳 Deploy da aplicação web-app-clientes via Kubernetes

Arquivos para criação dos Services e Deployments para subir via Kubernetes a aplicação do repositório [web-app-clientes](https://github.com/rafaeldalsenter/web-app-clientes). Para testes foi utilizado o [Minikube](https://kubernetes.io/docs/tasks/tools/install-minikube/)

Para subir o ambiente, basta rodar os comandos:

- Criar os Services e StatefulSets do banco de leitura (Mongo):
  ```
  kubectl create -f statefulset-mongo.yaml
  kubectl create -f services-mongo.yaml
  ```

- Criar os Services e StatefulSets do banco de escrita (PostgreSQL):
  ```
  kubectl create -f statefulset-postgres.yaml
  kubectl create -f services-postgres.yaml
  ```
- Criar o PersistentVolumeClaim para os bancos:
  ```
  kubectl create -f persistent-volume-claim.yaml
  ```
- Subir o Deploy da aplicação e o serviço de LoadBalance:
  ```
  kubectl create deployment.yaml
  kubectl create services.yaml
  ```
  
Após isso, rodar o comando `minikube service service-app --url` para obter o link da aplicação. Por padrão ele subirá somente um Pod da aplicação, porém via Dashboard (rodando o comando `minikube dashboard`) você consegue escalonar quando Pods da aplicação quiser, o service de LoadBalance fará o controle de tráfego entre os Pods :) 
