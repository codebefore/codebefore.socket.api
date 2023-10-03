node{
  docker.withRegistry(‘https://registry.example.com/', ‘svc-acct’) {
  
    checkout scm
    stage(‘Build’) {
      sh ‘docker-compose –f build-compose.yml run –rm compile’
    
    }
  }
}
