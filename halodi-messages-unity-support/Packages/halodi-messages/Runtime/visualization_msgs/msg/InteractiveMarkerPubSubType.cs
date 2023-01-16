using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarker" defined in "InteractiveMarker.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarker.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarker.idl instead.
*
*/
public class InteractiveMarkerPubSubType : Halodi.CDR.TopicDataType<InteractiveMarker>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarker_";


   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarker data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarker data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.description.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.menu_entries.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.MenuEntryPubSubType.getCdrSerializedSize(data.menu_entries[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.controls.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.InteractiveMarkerControlPubSubType.getCdrSerializedSize(data.controls[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarker data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      cdr.write_type_d(data.name);

      cdr.write_type_d(data.description);

      cdr.write_type_5(data.scale);

      	if(data.menu_entries == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int menu_entries_length = data.menu_entries.Count;
            cdr.write_type_2(menu_entries_length);
            for (int i0 = 0; i0 < menu_entries_length; i0++)
            {
      			visualization_msgs.msg.MenuEntryPubSubType.write(data.menu_entries[i0], cdr);	      }
        }
      	if(data.controls == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int controls_length = data.controls.Count;
            cdr.write_type_2(controls_length);
            for (int i0 = 0; i0 < controls_length; i0++)
            {
      			visualization_msgs.msg.InteractiveMarkerControlPubSubType.write(data.controls[i0], cdr);	      }
        }
   }

   public static void read(visualization_msgs.msg.InteractiveMarker data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.name = cdr.read_type_d();	
      data.description = cdr.read_type_d();	
      data.scale=cdr.read_type_5();
      	

      int menu_entries_length = cdr.read_type_2();
      data.menu_entries = new System.Collections.Generic.List<visualization_msgs.msg.MenuEntry>(menu_entries_length);
      for(int i = 0; i < menu_entries_length; i++)
      {
      	visualization_msgs.msg.MenuEntry new_menu_entries = visualization_msgs.msg.MenuEntryPubSubType.Create(); 
      	visualization_msgs.msg.MenuEntryPubSubType.read(new_menu_entries, cdr);
      	data.menu_entries.Add(new_menu_entries);	
      	
      }

      	

      int controls_length = cdr.read_type_2();
      data.controls = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerControl>(controls_length);
      for(int i = 0; i < controls_length; i++)
      {
      	visualization_msgs.msg.InteractiveMarkerControl new_controls = visualization_msgs.msg.InteractiveMarkerControlPubSubType.Create(); 
      	visualization_msgs.msg.InteractiveMarkerControlPubSubType.read(new_controls, cdr);
      	data.controls.Add(new_controls);	
      	
      }

      	

   }


	public override void Serialize(visualization_msgs.msg.InteractiveMarker data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.InteractiveMarker data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.InteractiveMarker data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.InteractiveMarker src, visualization_msgs.msg.InteractiveMarker target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.InteractiveMarker src, visualization_msgs.msg.InteractiveMarker target)
    {
    	Copy(src, target);
    }


}


}