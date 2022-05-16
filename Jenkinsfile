pipeline {
  agent any
  stages {
    stage('error') {
      steps {
        sh 'apt-get update && apt-get install nodejs && apt-get install npm '
        sh 'snap install --classic heroku'
      }
    }

  }
}