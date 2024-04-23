# Predicting-Cancer-Diagnostics-using-AI
Final Year Project Coursework for the University of Plymouth COMP3000 2023/2024

Cancer diagnosis remains a formidable challenge in healthcare, necessitating accurate and timely detection for effective treatment and improved patient outcomes. With recent advancements in AI and machine learning (ML), there is growing interest in leveraging these technologies to enhance diagnostic capabilities and revolutionize healthcare practices.

This project explores the potential of AI in predicting cancer diagnostics while also considering ethical and professional considerations, with the overarching goal of demonstrating its potential uses in cancer diagnostics.

The desktop application developed in this project will predict two types of cancers: breast and lung cancer. the former design is to be used by a doctor, and it will predict based on the doctor's input(measurements) whether the tumour is cancerous or not. while the latter is designed for medical staff in general, and it will be predicted based on a questionnaire.


## Before using the application!
The Dataset used to train the AIs are not mine, they are under CC laws. 
The Breast Cancer Dataset came from: https://archive.ics.uci.edu/dataset/17/breast+cancer+wisconsin+diagnostic
it is from a study made by William Wolberg, Olvi Mangasarian, Nick Street adn W. Street named "Nuclear feature extraction for breast tumor diagnosis" 1993 study link: https://www.semanticscholar.org/paper/Nuclear-feature-extraction-for-breast-tumor-Street-Wolberg/53f0fbb425bc14468eb3bf96b2e1d41ba8087f36

The Lung cancer dataset came from: https://www.kaggle.com/datasets/mysarahmadbhat/lung-cancer 

Both dataset can be used freely as long it follow CC BY-NC-SA 4.0, link: https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en. That states that You are free to:
Share — copy and redistribute the material in any medium or format
Adapt — remix, transform, and build upon the material
The licensor cannot revoke these freedoms as long as you follow the license terms.
Under the following terms:
Attribution — You must give appropriate credit , provide a link to the license, and indicate if changes were made . You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
NonCommercial — You may not use the material for commercial purposes .
ShareAlike — If you remix, transform, or build upon the material, you must distribute your contributions under the same license as the original.
No additional restrictions — You may not apply legal terms or technological measures that legally restrict others from doing anything the license permits.

## User Guides 
Installation guide 
Source code: https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI
Minimum system requirements
Operating system: Windows
Ram: 50 MB
Internet connection is not required
Instructions: 
Access and download the Github repository and locate the “Publish” folder, it can be found on:
 …\Predicting-Cancer-Diagnostics-using-AI\Cancer Diagonostics\Cancer Diagonostics\publish
Afterwards, click on either Setup or Cancer Diagnostics, it will display a window that will check for updates and ask you(when first open) to install some packages, this package that they referring to is the AI model used in the application. Once the installation is completed the application will open.
How to use Guide
The application consists of two types of cancer diagnostics, Breast and Lung cancer. The following section will demonstrate how to correctly use each.
Breast Cancer Diagnostics
![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/228f1745-ee1c-415d-bf0a-423e01c8a3e8)

 
To diagnose Breast cancer please insert each measurement into the corresponding box.
It consists of 3 categories of measurement mean, se and worst, the mean is the mean of all measurements in that category, se stands for Stardant of Error and worst is the bigger measurement of the taken.
To aid in inputting the measurements, you can paste them automatically if you have the measurements in the clipboard , this measurements must be in the correct order from right to left like reading a paragraph (Radius means, Texture means,…, Radius se, Texture se,…) if you want to test it out you can copy the measurement from Breast Cancer.csv in the dataset folder on the github repository 
Here a demonstration:

 ![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/36a93b4a-a0aa-404e-b254-84b138f1efc8)

![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/71579e04-cf57-402d-b55f-f2f5132bb318)

 
(copy the row)

![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/255101d1-ec9f-40cf-beb5-b5575b8f4743)
 
![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/01a9698e-56a4-47bb-a0a5-c6e2f2f84f51)

![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/2f871cb8-4796-41b3-bcaf-b55f340e0c65)


 
Lung Cancer Diagnostics
To diagnose Lung cancer please answer the questionnaire, the questionnaire questions are made as if you were a medical professional.

![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/6af9e2bd-b862-4a4a-aec6-553132858415)

 ![image](https://github.com/Mikeofp/Predicting-Cancer-Diagnostics-using-AI/assets/91840872/d2124548-4168-4b69-87c4-0da1f39bece8)


 
(the questionnaire input is just an example, you are free to answer on your own)
