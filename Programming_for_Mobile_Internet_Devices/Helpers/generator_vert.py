import os



# generate items one on top of another



class XmlGenerator:
    def __init__(self):
        self.output_lines = []

        self.items_list = [
            ("textViewFirstName", "fragment1TextViewFirstNameLabel", "TextView"),
            ("editTextFirstName", None, "EditText"),
            ("textViewLastName", "fragment1TextViewLastNameLabel", "TextView"),
            ("editTextLastName", None, "EditText"),
            ("textViewFacultyNumber", "fragment1TextViewFacultyNumberLabel", "TextView"),
            ("editTextFacultyNumber", None, "EditText"),
            ("textViewSpecialty", "fragment1TextViewSpecialtyLabel", "TextView"),
            ("spinnerSpecialty", None, "Spinner"),
            ("buttonSubmitt", "fragment1ButtonSubmittLabel", "Button"),
        ]

        self.output_filename = "tmp_xml"

    def save_output_text_content_to_file(self, filename=None):
        if filename == None:
            filename = self.output_filename

        if os.path.exists(filename):
            os.remove(filename)

        #save it
        with open(filename, 'w') as file_var:
            for line in self.output_lines:
                print(str(line)+"\n\n", file=file_var)

    def generate_output_xml(self, items_list=None):
        if items_list == None:
            items_list = self.items_list

        for idx in range(len(items_list)):
            if idx == 0:
                self.output_lines.append(self.get_item_string(None, items_list[idx], items_list[idx+1]))
            elif idx < len(items_list)-1:
                self.output_lines.append(self.get_item_string(items_list[idx-1], items_list[idx], items_list[idx+1]))
            else:
                self.output_lines.append(self.get_item_string(items_list[idx-1], items_list[idx], None))

    def get_item_string(self, prev_item, item, next_item):
        # android:layout_width="0dp"
        # android:layout_height="wrap_content"
        # android:layout_marginStart="8dp"
        # android:layout_marginEnd="8dp"

        ret_str = "\t<{}\n\t\tandroid:id=\"@+id/{}\"\n".format(item[2], item[0])
        if item[0].startswith("editText"):
            ret_str += "\t\tandroid:layout_width=\"0dp\"\n"
            ret_str += "\t\tandroid:layout_marginStart=\"8dp\"\n"
            ret_str += "\t\tandroid:layout_marginEnd=\"8dp\"\n"
            
        else:
            ret_str += "\t\tandroid:layout_width=\"wrap_content\"\n"
        ret_str += "\t\tandroid:layout_height=\"wrap_content\"\n"
        if item[1] != None:
            ret_str += "\t\tandroid:text=\"@string/{}\"\n".format(item[1])
        if prev_item != None:
            ret_str += "\t\tapp:layout_constraintTop_toBottomOf=\"@id/{}\"\n".format(prev_item[0])
        else:
            ret_str += "\t\tapp:layout_constraintTop_toTopOf=\"parent\"\n"
        ret_str += "\t\tapp:layout_constraintEnd_toEndOf=\"parent\"\n\t\tapp:layout_constraintStart_toStartOf=\"parent\"\n"
        if next_item != None:
            ret_str += "\t\tapp:layout_constraintBottom_toTopOf=\"@id/{}\"\n".format(next_item[0])
        else:
            ret_str += "\t\tapp:layout_constraintBottom_toBottomOf=\"parent\"\n"
        # app:layout_constraintBottom_toTopOf="@id/button_first"
        
        ret_str += "\t/>" 
        return ret_str

if __name__ == "__main__":
    gen = XmlGenerator()
    gen.generate_output_xml()
    gen.save_output_text_content_to_file()