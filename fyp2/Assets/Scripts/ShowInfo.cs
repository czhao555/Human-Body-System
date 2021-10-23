using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ShowInfo : MonoBehaviour
{
    public Button tutorial;
    public Button backToMain;
    public Button openSliderButton;
    public Slider slider;
    public Button Buttons;
    public GameObject Lungs;
    public GameObject panel;
    public GameObject thumbnailBox;
    public GameObject alveoli;
    public static int PassNumberofVideo;
    public Sprite[] videoThumbnail;
    private GameObject Parts = null;//  to store the child(lung part) of the parent(lung) that selected in toggle
    private string PartName = null; // string to store lungs part name, then pass it to display in button and pannel later.
    public Text title, body;
    ToggleGroup toggleGroupInstance;
    public Toggle OnlyShowSelectedPart_toggle;

    void Start()
    {
        toggleGroupInstance = GetComponent<ToggleGroup>();
    }

    

    public void OnButtonClick(string PartN)
    {
        openSliderButton.gameObject.SetActive(false);
        panel.gameObject.SetActive(true);
        backToMain.gameObject.SetActive(false);
        tutorial.gameObject.SetActive(false);
        switch (PartName)
        {

            case "Bone":
                {
                    
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[0];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Rib cage, in vertebrate anatomy, basketlike skeletal structure that forms the chest, or " +
                        "thorax, and is made up of the ribs and their corresponding attachments to the sternum (breastbone) " +
                        "and the vertebral column. The rib cage surrounds the lungs and the heart, serving as an important means " +
                        "of bony protection for these vital organs.In total, the rib cage consists of the 12 thoracic vertebrae " +
                        "and the 24 ribs, in addition to the sternum. With each succeeding rib, from the first, or uppermost, " +
                        "the curvature of the rib cage becomes more open. The rib cage is semirigid but expansile, " +
                        "able to increase in size. The small joints between the ribs and the vertebrae permit a gliding motion " +
                        "of the ribs on the vertebrae during breathing and other activities. The first seven ribs in the rib " +
                        "cage are attached to the sternum by pliable cartilages called costal cartilages; these ribs are called " +
                        "true ribs.Of the remaining five ribs, which are called false, the first three have their costal cartilages " +
                        "connected to the cartilage above them.The last two, the floating ribs, have their cartilages ending in the " +
                        "muscle in the abdominal wall.The configuration of the lower five ribs gives freedom for the expansion " +
                        "of the lower part of the rib cage and for the movements of the diaphragm, which has an extensive origin " +
                        "from the rib cage and the vertebral column.The motion is limited by the ligamentous attachments between " +
                        "ribs and vertebrae.";
                    break;
                }
            case "Right Upper Lobe":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[1];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The lung consists of five lobes. The left lung has a superior and inferior lobe, while the right lung has " +
                        "superior, middle, and inferior lobes. Thin walls of tissue called fissures separate the different lobes. The superior " +
                        "lobes of each lung are the uppermost pieces, also called the upper lobes. Each lobe receives air from its own branch of " +
                        "the bronchial tree, called lobar (or secondary) bronchi. Within the lungs, these bronchi are divided into smaller tubes. " +
                        "The smallest of these tubes is called a bronchiole. Bronchioles control the exchange of gases with the alveoli, the tiny" +
                        " air sacs within the lungs. Each lobe of the lungs has the same function: delivering oxygen into the bloodstream and removing " +
                        "carbon dioxide.Sections of lobe or entire lobes can be removed as a treatment for conditions such as lung cancer, tuberculosis, and emphysema.";
                    break;
                }
            case "Right Middle Lobe":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[2];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The lung consists of five lobes. The left lung has a superior and inferior lobe, while the right lung has superior, middle," +
                        " and inferior lobes. Thin walls of tissue called fissures separate the different lobes. Only the right lung has a middle lobe. As the" +
                        " name implies, this lobe is located between the upper and lower (also called the superior and inferior) lobes. Each lobe receives air" +
                        " from its own branch of the bronchial tree, called lobar (or secondary) bronchi. Within the lungs, these bronchi are divided into smaller" +
                        " tubes. The smallest of these tubes is called a bronchiole. Bronchioles control the exchange of gases with the alveoli, which are tiny air" +
                        " sacs in the lungs. Each lobe of the lung has the same physiologic function, bringing oxygen into the bloodstream and removing carbon dioxide." +
                        " Sections of a lobe, or even entire lobes can be removed as a treatment for conditions such as lung cancer, tuberculosis, and emphysema.";
                    break;
                }
            case "Right Inferior Lobe":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[3];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The inferior lobe is a section of the human lung. Each lung is divided into lobes; the right lung consists of the superior, " +
                        "middle, and inferior lobes, while the left lung consists of only the superior and inferior lobes. Note that both lungs contain an inferior" +
                        " lobe, and it is roughly a similar size to the superior lobe within each lung. An oblique fissure divides the superior and inferior lobes" +
                        " of the lung; in the right lung a horizontal fissure also separates the middle lobe. The oblique fissure is commonly found to follow the" +
                        " line of the sixth rib; however, variability has been noted. It is possible, though not common, to separate the inferior lobe from the rest" +
                        " of the lung and transplant it into another patient whose lungs do not or cannot function. This is a proposed alternative to entire-lung" +
                        " transplants from cadavers. It is a particularly strong alternative as a donor need not be deceased to donate the inferior lobe. This is" +
                        " known as lobar lung transplantation. Two donors donate one inferior lobe to the patient to replace the patient’s lungs. However, this is" +
                        " not yet a common procedure.";
                    break;
                }
            case "Left Upper Lobe":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[4];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The lung consists of five lobes. The left lung has a superior and inferior lobe, while the right lung has superior, middle, " +
                        "and inferior lobes. Thin walls of tissue called fissures separate the different lobes. The superior lobes of each lung are the uppermost " +
                        "pieces, also called the upper lobes. Each lobe receives air from its own branch of the bronchial tree, called lobar (or secondary) bronchi." +
                        " Within the lungs, these bronchi are divided into smaller tubes. The smallest of these tubes is called a bronchiole. Bronchioles control the" +
                        " exchange of gases with the alveoli, the tiny air sacs within the lungs. Each lobe of the lungs has the same function: delivering oxygen into" +
                        " the bloodstream and removing carbon dioxide.Sections of lobe or entire lobes can be removed as a treatment for conditions such as lung cancer," +
                        " tuberculosis, and emphysema.";
                    break;
                }
            case "Left Inferior Lobe":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[5];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The left lower lobe (LLL) is one of two lobes in the left lung. It is separated from the left upper lobe by the left oblique fissure" +
                        " and subdivided into four bronchopulmonary segments. \n\nThe LLL lies in the posterior and lower aspect of the left hemithorax and contains" +
                        " four bronchopulmonary segments:\n:superior segment\n:anteromedial segment\n:lateral segment\n:posterior segment\n\nLike all the pulmonary lobes," +
                        " it is lined by visceral pleura which reflects at the pulmonary hilum where it is continuous with the parietal pleura. The left lower lobe" +
                        " bronchus arises as the inferiorly angled continuation of the left main bronchus to traverse the left hilum into the LLL. The LLL is separated" +
                        " from the left upper lobe posterosuperiorly by the left oblique fissure.";
                    break;
                }
            case "Right Pulmonary Vein":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[6];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Veins are the blood vessels that carry blood to the heart. Pulmonary veins are responsible for carrying " +
                        "oxygenated blood from the lungs back to the left atrium of the heart. This differentiates the pulmonary veins from" +
                        " other veins in the body, which are used to carry deoxygenated blood from the rest of the body back to the heart. " +
                        "Humans have four pulmonary veins in total, two from each lung. There are two right pulmonary veins, known as the " +
                        "right superior and right inferior veins. These carry blood from the right lung. Each pulmonary vein is linked to a " +
                        "network of capillaries (small blood vessels) in the alveoli of each lung. Alveoli are tiny air sacs within the lungs" +
                        " where oxygen and carbon dioxide are exchanged. These capillaries eventually join together to form a single blood vessel" +
                        " from each lobe of the lung. The right lung contains three lobes, while the left lung is slightly small and contains " +
                        "only two lobes. Initially there are three vessels for the right lung, but the veins from the middle and upper lobes of" +
                        " the right lung tend to fuse together to form two right pulmonary veins. The right pulmonary veins pass behind the right" +
                        " atrium and another large blood vessel known as the superior vena cava.";
                    break;
                }
            case "Right Pulmonary Artery":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[7];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The pulmonary artery begins at the base of the heart’s right ventricle. It is approximately 3 cm in diameter " +
                        "and 5 cm in length and it eventually divides into the left pulmonary artery and the right pulmonary artery. These arteries" +
                        " then deliver oxygen-depleted blood to each corresponding lung. This is one of the rare arteries that carry deoxygenated blood;" +
                        " the other location is found within the fetus, where the umbilical arteries are. A variety of lung diseases can " +
                        "cause pulmonary hypertension, which is when the blood pressure increases in the pulmonary artery. Pulmonary hypertension " +
                        "can be a consequence or a cause; for example, it may be a consequence of heart disease or a cause of right-ventricular heart " +
                        "failure. Other conditions that may cause pulmonary hypertension include scleroderma and pulmonary embolism. Scleroderma is a" +
                        " chronic systemic autoimmune condition that causes hardening of the skin and connective tissues. A pulmonary embolism occurs" +
                        " when a substance from another place in the body blocks the left or right pulmonary artery.";
                    break;
                }
            case "Left Pulmonary Vein":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[8];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Within the body, there are a total of four pulmonary veins, and all of them connect to the left atrium of the heart." +
                        " The heart pumps oxygen-depleted blood into the lungs via the pulmonary arteries. Once the blood has been oxygenated, " +
                        "it returns to the heart via the pulmonary veins. Then, the heart circulates this newly oxygenated blood throughout the body. " +
                        "In this way, pulmonary veins are different from other veins in the body, which are used to carry deoxygenated blood from " +
                        "the rest of the body back to the heart. The left pulmonary veins connect with the left lung, and the lungs themselves are" +
                        " filled with hollow air sacs called alveoli. This is where oxygen is removed from inhaled air. This also works as a gas" +
                        " exchange. Oxygen enters the blood while carbon dioxide leaves the blood stream. This carbon dioxide is then exhaled out of the body.";
                    break;
                }
            case "Left Pulmonary Artery":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[9];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The main pulmonary artery is responsible for transporting oxygen-depleted blood away from the heart and back toward the lungs. " +
                        "The main artery splits into the left pulmonary artery and the right pulmonary artery, each of which directs the blood to the corresponding" +
                        " lung. Along with the umbilical arteries, these are the sole arteries in the body that transport oxygen-depleted blood. The umbilical" +
                        " arteries are located in the uterus. The pulmonary artery, or pulmonary trunk, originates from the bottom of the right ventricle of the" +
                        " heart. The artery is wide and short, measuring 1.2 inches wide and 2 inches long. When blood pressure increases in the right or left" +
                        " pulmonary artery or the main pulmonary artery, this is referred to as pulmonary hypertension and can result in symptoms such as " +
                        "fainting, dizziness and shortness of breath. When someone suffers from pulmonary hypertension, it can cause heart failure in the " +
                        "right ventricle of the heart. In other instances, it can be a consequence of other conditions such as heart disease, scleroderma or a pulmonary embolism.";
                    break;
                }
            case "Trachea":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[10];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The trachea, commonly known as the windpipe, is a tube about 4 inches long and less than an inch in diameter in most people. " +
                        "The trachea begins just under the larynx (voice box) and runs down behind the breastbone (sternum). The trachea then divides into " +
                        "two smaller tubes called bronchi: one bronchus for each lung. The trachea is composed of about 20 rings of tough cartilage. The back " +
                        "part of each ring is made of muscle and connective tissue. Moist, smooth tissue called mucosa lines the inside of the trachea. " +
                        "The trachea widens and lengthens slightly with each breath in, returning to its resting size with each breath out.\n\n" +
                        "Trachea Conditions \n Tracheal stenosis: Inflammation in the trachea can lead to scarring and narrowing of the windpipe.Surgery " +
                        "or endoscopy may be needed to correct the narrowing(stenosis), if severe. \nTracheoesophageal fistula: An abnormal channel forms" +
                        " to connect the trachea and the esophagus.Passage of swallowed food from the esophagus into the trachea causes serious lung problems." +
                        " \nTracheal foreign body: An object is inhaled (aspirated)and lodges in the trachea or one of its branches.A procedure called bronchoscopy" +
                        " is usually needed to remove a foreign body from the trachea. \nTracheal cancer: Cancer of the trachea is quite rare. Symptoms can include " +
                        "coughing or difficulty breathing. \nTracheomalacia: The trachea is soft and floppy rather than rigid, usually due to a birth defect.In adults, " +
                        "tracheomalacia is generally caused by injury or by smoking.\nTracheal obstruction: A tumor or other growth can compress and narrow the trachea," +
                        " causing difficulty breathing.A stent or surgery is needed to open the trachea and improve breathing.";
                    break;
                }
            case "Primary Bronchus":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[11];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "The first bronchi branch from trachea, and they are the right and left main bronchi. These bronchi are the widest and they enter the lung. " +
                        "After entering the lungs, the bronchi continue to branch further into the secondary bronchi, known as lobar bronchi, which then branch into tertiary " +
                        "(segmental) bronchi.\n The primary bronchi have cartilage and a mucous membrane that are similar to those found in the trachea. Additionally, " +
                        "hyaline cartilage forms an incomplete ring in the bronchi that gives them the characteristic “D” - shaped appearance in the larger bronchi, and" +
                        " as small “plates and islands” in smaller-sized bronchi.";
                    break;
                }
            case "Secandary Bronchus":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[12];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Secondary bronchi (also known as lobar bronchi) arise from the primary bronchi, with each one serving as the" +
                        " airway to a specific lobe of the lung. They have relatively large lumens that are lined by respiratory epithelium. " +
                        "There is a smooth muscle layer below the epithelium arranged as two ribbons of muscle that spiral in opposite directions. " +
                        "This smooth muscle layer contains seromucous glands. Irregularly arranged plates of hyaline cartilage surround the smooth muscle. " +
                        "These plates give structural support to the bronchus and maintain the patency of the lumen.";
                    break;
                }
            case "Tertiary Bronchus":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[13];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Tertiary bronchi are located near the bottom of these organs, just above the bronchioles. No gas exchanges " +
                        "occur in any of the bronchi. When the bronchi become swollen due to irritants or infection, bronchitis results and makes " +
                        "breathing more difficult. The tertiary bronchi (also known as the segmental bronchi) arise from the secondary bronchi. " +
                        "The respiratory epithelium lining their lumen is surrounded by a layer of smooth muscle. This layer is composed of two" +
                        " ribbons of smooth muscle that spiral in opposite directions. The smooth muscle layer is surrounded by irregular plates" +
                        " of hyaline cartilage which help maintain the patency of the airway.Each of the tertiary bronchi serves a specific " +
                        "bronchopulmonary segment. There are 10 tertiary bronchi in the right lung, and eight in the left. The tertiary bronchi " +
                        "get smaller and divide into primary bronchioles.";
                    break;
                }
            case "Alveoli":
                {
                    thumbnailBox.GetComponent<Image>().sprite = videoThumbnail[14];
                    panel.gameObject.SetActive(true);
                    title.text = PartName;
                    body.text = "Tiny air sacs at the end of the bronchioles (tiny branches of air tubes in the lungs)." +
                        " The alveoli are where the lungs and the blood exchange oxygen and carbon dioxide during the " +
                        "process of breathing in and breathing out. Oxygen breathed in from the air passes through the " +
                        "alveoli and into the blood and travels to the tissues throughout the body. Carbon dioxide travels" +
                        " in the blood from the body's tissues and passes through the alveoli to be breathed out.";
                    break;
                }
            default:
                break;
        }
      
    }

    public void CheckToggleOn()
    {
        foreach (Toggle t in toggleGroupInstance.ActiveToggles())
        {
            
            if (Parts != null)
            {
                    Parts.GetComponent<Outline>().enabled = false;

                Debug.Log("inside part");
                Buttons.gameObject.SetActive(false);
                PartName = null;
                Parts = null;
                
            }
            for (int j =0; j<15; j++)
            {
                
                if (t.isOn == true && t.name == "Toggle"+j)
                {
                    OnlyShowSelectedPart_toggle.interactable = true;
                    PassNumberofVideo = j;
                    if (j == 0)
                    {
                        PartName = "Bone";
                        slider.value = 0;
                    }
                    else if (j == 1)
                    {
                        PartName = "Right Upper Lobe";
                        slider.value = 1;
                    }
                    else if (j == 2)
                    {
                        PartName = "Right Middle Lobe";
                        slider.value = 1;
                    }
                    else if (j == 3)
                    {
                        PartName = "Right Inferior Lobe";
                        slider.value = 1;
                    }
                    else if (j == 4)
                    {
                        PartName = "Left Upper Lobe";
                        slider.value = 1;
                    }
                    else if (j == 5)
                    {
                        PartName = "Left Inferior Lobe";
                        slider.value = 1;
                    }
                    else if (j == 6)
                    {
                        PartName = "Right Pulmonary Vein";
                        slider.value = 2;
                    }
                    else if (j == 7)
                    {
                        PartName = "Right Pulmonary Artery";
                        slider.value = 2;
                    }
                    else if (j == 8)
                    {
                        PartName = "Left Pulmonary Vein";
                        slider.value = 2;
                    }
                    else if (j == 9)
                    {
                        PartName = "Left Pulmonary Artery";
                        slider.value = 2;
                    }
                    else if (j == 10)
                    {
                        PartName = "Trachea";
                        slider.value = 3;
                    }
                    else if (j == 11)
                    {
                        PartName = "Primary Bronchus";
                        slider.value = 3;
                    }
                    else if (j == 12)
                    {
                        PartName = "Secandary Bronchus";
                        slider.value = 3;
                    }
                    else if (j == 13)
                    {
                        PartName = "Tertiary Bronchus";
                        slider.value = 3;
                    }
                    else
                    {
                        PartName = "Alveoli";
                        slider.value = 4;
                    }

                    if(j>=0 && j <= 13)
                    {
                        Parts = Lungs.transform.Find("Part" + j).gameObject;
                        Parts.GetComponent<Outline>().enabled = true;
                    }
                    else
                    {
                        Parts = alveoli;
                    }
                    
                    Buttons.GetComponentInChildren<Text>().text = PartName;
                    Buttons.gameObject.SetActive(true);
                    Buttons.onClick.AddListener(() => OnButtonClick(PartName));
                    slider.interactable = false;
                    OnlyShowSelectedPart_toggle.isOn = false; // deselect "only show selected part" toggle
                }
            }
            
        }
        if (!toggleGroupInstance.AnyTogglesOn())
        {
            if (PassNumberofVideo >=0 && PassNumberofVideo <= 13)
            {
                Parts.GetComponent<Outline>().enabled = false;
            }
            Buttons.gameObject.SetActive(false);
            slider.interactable = true;
            panel.gameObject.SetActive(false);
            Parts = null; 
            PartName = null;
            OnlyShowSelectedPart_toggle.isOn = false;
            OnlyShowSelectedPart_toggle.interactable = false;  // set it not clickable when no lung part is selected
        }
    }
    

}
