using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "BatteryState" defined in "BatteryState.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from BatteryState.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit BatteryState.idl instead.
*
*/
public class BatteryStatePubSubType : Halodi.CDR.TopicDataType<BatteryState>
{
   public override string Name => "sensor_msgs::msg::dds_::BatteryState_";


   
   public override void serialize(sensor_msgs.msg.BatteryState data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.BatteryState data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.BatteryState data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.BatteryState data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.cell_voltage.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.cell_temperature.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.location.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.serial_number.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.BatteryState data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_5(data.voltage);

      cdr.write_type_5(data.temperature);

      cdr.write_type_5(data.current);

      cdr.write_type_5(data.charge);

      cdr.write_type_5(data.capacity);

      cdr.write_type_5(data.design_capacity);

      cdr.write_type_5(data.percentage);

      cdr.write_type_9(data.power_supply_status);

      cdr.write_type_9(data.power_supply_health);

      cdr.write_type_9(data.power_supply_technology);

      cdr.write_type_7(data.present);

      	if(data.cell_voltage == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int cell_voltage_length = data.cell_voltage.Count;
            cdr.write_type_2(cell_voltage_length);
            for (int i0 = 0; i0 < cell_voltage_length; i0++)
            {
      			cdr.write_type_5(data.cell_voltage[i0]);
            }
        }
      	if(data.cell_temperature == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int cell_temperature_length = data.cell_temperature.Count;
            cdr.write_type_2(cell_temperature_length);
            for (int i0 = 0; i0 < cell_temperature_length; i0++)
            {
      			cdr.write_type_5(data.cell_temperature[i0]);
            }
        }
      cdr.write_type_d(data.location);

      cdr.write_type_d(data.serial_number);

   }

   public static void read(sensor_msgs.msg.BatteryState data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.voltage=cdr.read_type_5();
      	
      data.temperature=cdr.read_type_5();
      	
      data.current=cdr.read_type_5();
      	
      data.charge=cdr.read_type_5();
      	
      data.capacity=cdr.read_type_5();
      	
      data.design_capacity=cdr.read_type_5();
      	
      data.percentage=cdr.read_type_5();
      	
      data.power_supply_status=cdr.read_type_9();
      	
      data.power_supply_health=cdr.read_type_9();
      	
      data.power_supply_technology=cdr.read_type_9();
      	
      data.present=cdr.read_type_7();
      	

      int cell_voltage_length = cdr.read_type_2();
      data.cell_voltage = new System.Collections.Generic.List<float>(cell_voltage_length);
      for(int i = 0; i < cell_voltage_length; i++)
      {
      	data.cell_voltage.Add(cdr.read_type_5());
      	
      	
      }

      	

      int cell_temperature_length = cdr.read_type_2();
      data.cell_temperature = new System.Collections.Generic.List<float>(cell_temperature_length);
      for(int i = 0; i < cell_temperature_length; i++)
      {
      	data.cell_temperature.Add(cdr.read_type_5());
      	
      	
      }

      	
      data.location = cdr.read_type_d();	
      data.serial_number = cdr.read_type_d();	

   }


    public static void Copy(sensor_msgs.msg.BatteryState src, sensor_msgs.msg.BatteryState target)
    {
        target.Set(src);
    }


}


}