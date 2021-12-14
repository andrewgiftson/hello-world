pipeline {
    agent any

    
    stages{    
     stage('Organise Files')
        {                         
         steps{  
                script
                {                        
                  File sourceFolder = new File("/Home/andrew/workspace/Online food order/");
                    File  destinationFolder = new File("/var/www/html/");                                                   
                    File[] listOfFiles = sourceFolder.listFiles();
                    echo "Files Total: " + listOfFiles.length;  

                    for (File file : listOfFiles) {
                        if (file.isFile()) {
                            echo file.getName()                                                                
                            Files.copy(Paths.get(file.path), Paths.get(destinationFolder));                                   
                        }
                    }            
                }                             
              }                           
        } 
    

        stage('Create') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Build') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Test') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Release') {
            steps {
                echo 'Hello World'
            }
        }
    }
}
