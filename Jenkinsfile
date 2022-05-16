pipeline {
  agent any
  stages {
    stage('error') {
      steps {
        sh '''apt update
apt install nodejs
apt install npm '''
        sh 'snap install --classic heroku'
      }
    }

  }
}