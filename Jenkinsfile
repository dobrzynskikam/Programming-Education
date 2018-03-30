pipeline {
  agent any
  stages {
    stage('Hello world') {
      steps {
        bat(script: 'echo "Hello"', returnStatus: true)
        echo 'Hello World'
      }
    }
  }
}