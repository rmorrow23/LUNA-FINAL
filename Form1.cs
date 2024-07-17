using Moonbase.Properties;
using System;
using System.IO; 
using System.Windows.Forms; 

namespace Moonbase
{
    public partial class FormMain : Form
    {
        // Global variables for room names, descriptions, background images, current position, and locations
        public string[] RmNm = new string[8];
        public string[] RmDsc = new string[8];
        public string[] RmBack = new string[8];
        public string currentPosition;
        public string[] location = new string[8];
        public string user;

        // Class to represent an Area in the moonbase
        class Area
        {
            private string[] roomName = new string[8]; // Array to hold room names
            private string[] roomDescription = new string[8]; // Array to hold room descriptions

            // Constructor to initialize the roomName and roomDescription arrays
            public Area(string[] RmNm, string[] RmDsc)
            {
                for (int i = 0; i < roomName.Length; i++)
                {
                    roomName[i] = RmNm[i];
                    roomDescription[i] = RmDsc[i];
                }
            }

            // Method to get the name of a room
            public string getRoom(int i)
            {
                return roomName[i];
            }

            // Method to get the description of a room
            public string getDesc(int i)
            {
                return roomDescription[i];
            }
        }

        // Constructor for the FormMain class
        public FormMain()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Event handler for form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize array with the different locations
            location[0] = "Command Center";
            location[1] = "Laboratory";
            location[2] = "Living Quarters";
            location[3] = "Medical Bay";
            location[4] = "Circular Corridor";
            location[5] = "Cafeteria";
            location[6] = "Entertainment Room";
            location[7] = "Movie Theater";

            // Initialize array with Room Names
            RmNm[0] = "Lunar Operations Command Center";
            RmNm[1] = "Lunar Laboratory";
            RmNm[2] = "Lunar Living Quarters";
            RmNm[3] = "Lunar Medical Bay";
            RmNm[4] = "Lunar Circular Corridor";
            RmNm[5] = "Lunar Cafeteria";
            RmNm[6] = "Lunar Entertainment Room";
            RmNm[7] = "Lunar Movie Theater";

            // Initialize array with room descriptions
            RmDsc[0] = "The Lunar Operations Command Center is the heart of the moonbase, featuring walls of sleek metallic panels embedded with soft, ambient LED lights that create a futuristic glow. Large, reinforced windows offer a breathtaking view of the lunar landscape and Earth. High-tech consoles with holographic displays dominate the room, providing real-time data and interactive controls for managing base operations.";
            RmDsc[1] = "The Lunar Laboratory is a hub of scientific discovery, featuring sleek metallic walls illuminated by ambient LED lights. Large windows offer a view of the lunar surface, enhancing the high-tech atmosphere. Equipped with advanced scientific instruments and robotic assistants, the lab enables groundbreaking experiments and efficient research.";
            RmDsc[2] = "The Lunar Living Quarters offer a cozy refuge with sleek metallic walls and warm LED lighting. Large windows provide a stunning lunar landscape view. Modern furniture, including a comfortable bed, seating area, and holographic work desk, ensure comfort and functionality, while personal items add a homely touch.";
            RmDsc[3] = "The Lunar Medbay is a state-of-the-art medical facility with sleek metallic walls and soft LED lighting. Large windows provide a calming view of the lunar surface. Equipped with advanced medical technology and robotic assistants, the medbay ensures top-notch care and efficient patient management.";
            RmDsc[4] = "The Lunar Circular Corridor is a striking feature of the moonbase, with its sleek metallic walls and ambient LED lighting creating a modern, minimalist aesthetic. The smooth, slightly reflective floor enhances the futuristic atmosphere, while clear directional signage ensures easy navigation. Large windows provide captivating views of the lunar landscape, and the hallway is equipped with security cameras and automated doors, balancing functionality with visual appeal.";
            RmDsc[5] = "The Lunar Cafeteria is a sleek, modern dining area with metallic walls and ambient LED lighting, creating a futuristic ambiance. Large windows offer stunning views of the lunar landscape, making every meal an extraordinary experience. Equipped with high-tech vending machines and a robotic server, the cafeteria combines functionality with comfort.";
            RmDsc[6] = "The Lunar Entertainment Hub is designed for relaxation and fun, featuring advanced gaming consoles, holographic game tables, and virtual reality stations. The room's sleek metallic walls and ambient LED lighting enhance the futuristic feel, while comfortable seating areas provide a perfect spot for socializing. Large windows allow for a breathtaking view of the lunar surface, adding to the room's appeal.";
            RmDsc[7] = "The Lunar Movie Theater offers a cozy atmosphere with sleek metallic walls and ambient LED lighting, perfect for an immersive viewing experience. Comfortable reclining seats, each with individual control panels, ensure personalized comfort while watching films on the large holographic screen. Sound-absorbing materials enhance audio quality, and large windows provide a stunning backdrop of the lunar landscape.";
            //get user name from file
            ReadNameFromFile();
            // Simulate a click on the Circular Corridor button to set the initial room
            btnHallway_Click(this, EventArgs.Empty);
            
        }

        // Method to update the user's current position
        private void UpdateUserPosition(string newPosition)
        {
            currentPosition = newPosition; // Update the current position
            LogUserPosition(); // Log the new position
            disableNav(currentPosition); // Disable navigation based on the new position
        }

        // Method to log the user's current position
        private void LogUserPosition()
        {
            string logFilePath = "user_location_log.txt"; // Log file path
            string logMessage = $"{DateTime.Now}: {user} moved to {currentPosition}"; // Log message

            try
            {
                // Save the new location to the specified log file
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Show error message if logging fails
                MessageBox.Show($"Error logging user position: {ex.Message}");
            }
        }

        // Method to disable navigation buttons based on the current location
        public void disableNav(string currentlocation)
        {
            if (currentlocation == location[4]) // Circular Corridor
            {
                // Re-enable all buttons except the main hallway
                commandCenterBTN.Enabled = true;
                labBTN.Enabled = true;
                livingQtBTN.Enabled = true;
                medBayBTN.Enabled = true;
                btnCafe.Enabled = true;
                btnEntertain.Enabled = true;
                btnMovie.Enabled = true;
                btnHallway.Enabled = false;
                LobbyBTN.Enabled = true;
                btnNumberGuess.Visible = false;
                btnTicTacToe.Visible = false;
            }
            else if (currentlocation == location[6])
            {
                commandCenterBTN.Enabled = false;
                labBTN.Enabled = false;
                livingQtBTN.Enabled = false;
                medBayBTN.Enabled = false;
                btnCafe.Enabled = false;
                btnEntertain.Enabled = false;
                btnMovie.Enabled = false;
                btnHallway.Enabled = true;
                btnNumberGuess.Visible = true;
                btnTicTacToe.Visible = true;
                LobbyBTN.Enabled = false;
            }

            else
            {
                // Set all buttons to disabled except the main hallway
                commandCenterBTN.Enabled = false;
                labBTN.Enabled = false;
                livingQtBTN.Enabled = false;
                medBayBTN.Enabled = false;
                btnCafe.Enabled = false;
                btnEntertain.Enabled = false;
                btnMovie.Enabled = false;
                btnHallway.Enabled = true;
                LobbyBTN.Enabled = false;
                btnNumberGuess.Visible = false;
                btnTicTacToe.Visible = false;
            }

             
        }

        // Event handler for room name textbox text changed
        private void TBRoomName_TextChanged(object sender, EventArgs e)
        {
            // Handle any changes to the room name textbox if necessary
        }

        // Event handler for label click
        private void label2_Click(object sender, EventArgs e)
        {
            // Handle any actions related to label2 if necessary
        }

        // Event handler for Command Center button click
        private void commandCenterBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(0); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(0); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.command_center; // Set the background image
            UpdateUserPosition("Command Center"); // Update the user's position
        }

        // Event handler for Laboratory button click
        private void labBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(1); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(1); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.lab; // Set the background image
            UpdateUserPosition("Laboratory"); // Update the user's position
        }

        // Event handler for Medical Bay button click
        private void medBayBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(3); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(3); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.medbay; // Set the background image
            UpdateUserPosition("Medical Bay"); // Update the user's position
        }

        // Event handler for Living Quarters button click
        private void livingQtBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(2); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(2); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.living; // Set the background image
            UpdateUserPosition("Living Quarters"); // Update the user's position
        }

        // Event handler for Circular Corridor button click
        private void btnHallway_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(4); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(4); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.hallway; // Set the background image
            UpdateUserPosition("Circular Corridor"); // Update the user's position
        }

        // Event handler for Cafeteria button click
        private void btnCafe_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(5); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(5); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.cafe; // Set the background image
            UpdateUserPosition("Cafeteria"); // Update the user's position
        }

        // Event handler for Entertainment Room button click
        private void btnEntertain_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(6); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(6); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.entertainment; // Set the background image
            UpdateUserPosition("Entertainment Room"); // Update the user's position
            
        }

        // Event handler for Movie Theater button click
        private void btnMovie_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(7); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(7); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.movie; // Set the background image
            UpdateUserPosition("Movie Theater"); // Update the user's position
        }

        // Event handler for Lobby button click
        private void LobbyBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(4); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(4); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.lobby; // Set the background image
            UpdateUserPosition("Lobby"); // Update the user's position
        }

        private void userLBL_Click(object sender, EventArgs e)
        {
            Welcome frm = new Welcome();
            this.Hide();
            frm.Show();
        }


        private void ReadNameFromFile()
        {
            string filePath = "name.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the name from the file
                    string name = File.ReadAllText(filePath);
                    // Display the name in the TextBox
                    userLBL.Text = name;
                    user = name;
                }
                else 
                { //display message if file does not exist
                    MessageBox.Show("File " + filePath + " does not exist!"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading name: {ex.Message}");
            }
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            //show the tictactoe game
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Show();
        }

        private void btnNumberGuess_Click(object sender, EventArgs e)
        {
            //show the guessing game
            NumberGuessing frm = new NumberGuessing();
            frm.Show();
        }

        private void btnLocationLog_Click(object sender, EventArgs e)
        {
            //show the location logs
            LogViewerForm logFRM = new LogViewerForm();
            logFRM.Show();
        }
    }
}
