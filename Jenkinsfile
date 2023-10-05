pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        sh 'docker build -t codebefore-socket-api:0.0.1 .' 
        sh 'echo env.TEST_VAR'
      }
    }
    stage('deploy') {
      steps {
        sh 'docker run -d --rm --name codebefore-socket-api -p 9090:80 -p 9091:443 codebefore-socket-api:0.0.1'
      }
    }
    
  }
}
