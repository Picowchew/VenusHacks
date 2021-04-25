


// Imports the Google Cloud client library.
const {Storage} = require('@google-cloud/storage');
require('dotenv').config();
const axios=require("axios");

// Instantiates a client. If you don't specify credentials when constructing
// the client, the client library will look for credentials in the
// environment.
const storage = new Storage();
// Makes an authenticated API request.
async function listBuckets() {
  try {
    const results = await storage.getBuckets();

    const [buckets] = results;

    console.log('Buckets:');
    buckets.forEach(bucket => {
      console.log(bucket.name);
    });
  } catch (err) {
    console.error('ERROR:', err);
  }
}
listBuckets();


const postData = (data) => {

 
  var uri = 'localhost';
  //log URI
  console.log(uri);


  var settings = {
      method: 'POST',
      url: uri, 
      body: {
        "requests":[
          {
            "image":{
              "content":data
            }
            
          }
        ]
      }
   
  };

 
  $.ajax(settings).done(function (response) {
  console.log(response);
  });
}




async function quickstart() {
  // Imports the Google Cloud client library
  const vision = require('@google-cloud/vision');

  // Creates a client
  const client = new vision.ImageAnnotatorClient();
  var words=[];


  /**
   * TODO(developer): Uncomment the following line before running the sample.
   */

  
  // Performs text detection on the local file
  const [result] = await client.textDetection(fileName);
  const detections = result.textAnnotations;
  console.log('Text:');
  detections.forEach(text => words.push(text.description));
  console.log(words);


}
quickstart();
postData(words);



