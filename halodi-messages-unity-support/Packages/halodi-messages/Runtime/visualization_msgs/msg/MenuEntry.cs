using System.Text;
namespace visualization_msgs.msg
{


/**
       * MenuEntry message.
       * 
       * Each InteractiveMarker message has an array of MenuEntry messages.
       * A collection of MenuEntries together describe a
       * menu/submenu/subsubmenu/etc tree, though they are stored in a flat
       * array.  The tree structure is represented by giving each menu entry
       * an ID number and a "parent_id" field.  Top-level entries are the
       * ones with parent_id = 0.  Menu entries are ordered within their
       * level the same way they are ordered in the containing array.  Parent
       * entries must appear before their children.
       * 
       * Example:
       * - id = 3
       * parent_id = 0
       * title = "fun"
       * - id = 2
       * parent_id = 0
       * title = "robot"
       * - id = 4
       * parent_id = 2
       * title = "pr2"
       * - id = 5
       * parent_id = 2
       * title = "turtle"
       * 
       * Gives a menu tree like this:
       * - fun
       * - robot
       * - pr2
       * - turtle
       */
[System.Serializable]
public class MenuEntry : Halodi.CDR.DataType<MenuEntry>
{

	public Halodi.CDR.TopicDataType<MenuEntry> Type => new MenuEntryPubSubType();
	
   /**
          * Command_type stores the type of response desired when this menu
          * entry is clicked.
          * FEEDBACK: send an InteractiveMarkerFeedback message with menu_entry_id set to this entry's id.
          * ROSRUN: execute "rosrun" with arguments given in the command field (above).
          * ROSLAUNCH: execute "roslaunch" with arguments given in the command field (above).
          */
   public const byte FEEDBACK = (byte) 0;
   public const byte ROSRUN = (byte) 1;
   public const byte ROSLAUNCH = (byte) 2;
   /**
            * ID is a number for each menu entry.  Must be unique within the
            * control, and should never be 0.
            */
   public uint id;
   /**
            * ID of the parent of this menu entry, if it is a submenu.  If this
            * menu entry is a top-level entry, set parent_id to 0.
            */
   public uint parent_id;
   /**
            * menu / entry title
            */
   public string title;
   /**
            * Arguments to command indicated by command_type (below)
            */
   public string command;
   public byte command_type;


   public void Set(MenuEntry other)
   {
      id = other.id;

      parent_id = other.parent_id;

      title = other.title;

      command = other.command;

      command_type = other.command_type;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MenuEntry {");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("parent_id=");
      builder.Append(this.parent_id);      builder.Append(", ");
      builder.Append("title=");
      builder.Append(this.title);      builder.Append(", ");
      builder.Append("command=");
      builder.Append(this.command);      builder.Append(", ");
      builder.Append("command_type=");
      builder.Append(this.command_type);
      builder.Append("}");
      return builder.ToString();
   }
}


}