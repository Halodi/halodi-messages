// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/BatteryStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_HPP_
#define HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__BatteryStatus __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__BatteryStatus __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct BatteryStatus_
{
  using Type = BatteryStatus_<ContainerAllocator>;

  explicit BatteryStatus_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->battery_status_level = 0;
      this->battery_voltage = 0.0;
      this->low_battery_voltage = 0.0;
      this->shutdown_battery_voltage = 0.0;
    }
  }

  explicit BatteryStatus_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->battery_status_level = 0;
      this->battery_voltage = 0.0;
      this->low_battery_voltage = 0.0;
      this->shutdown_battery_voltage = 0.0;
    }
  }

  // field types and members
  using _battery_status_level_type =
    unsigned char;
  _battery_status_level_type battery_status_level;
  using _battery_voltage_type =
    double;
  _battery_voltage_type battery_voltage;
  using _low_battery_voltage_type =
    double;
  _low_battery_voltage_type low_battery_voltage;
  using _shutdown_battery_voltage_type =
    double;
  _shutdown_battery_voltage_type shutdown_battery_voltage;

  // setters for named parameter idiom
  Type & set__battery_status_level(
    const unsigned char & _arg)
  {
    this->battery_status_level = _arg;
    return *this;
  }
  Type & set__battery_voltage(
    const double & _arg)
  {
    this->battery_voltage = _arg;
    return *this;
  }
  Type & set__low_battery_voltage(
    const double & _arg)
  {
    this->low_battery_voltage = _arg;
    return *this;
  }
  Type & set__shutdown_battery_voltage(
    const double & _arg)
  {
    this->shutdown_battery_voltage = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::BatteryStatus_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::BatteryStatus_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::BatteryStatus_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::BatteryStatus_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__BatteryStatus
    std::shared_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__BatteryStatus
    std::shared_ptr<halodi_msgs::msg::BatteryStatus_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const BatteryStatus_ & other) const
  {
    if (this->battery_status_level != other.battery_status_level) {
      return false;
    }
    if (this->battery_voltage != other.battery_voltage) {
      return false;
    }
    if (this->low_battery_voltage != other.low_battery_voltage) {
      return false;
    }
    if (this->shutdown_battery_voltage != other.shutdown_battery_voltage) {
      return false;
    }
    return true;
  }
  bool operator!=(const BatteryStatus_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct BatteryStatus_

// alias to use template instance with default allocator
using BatteryStatus =
  halodi_msgs::msg::BatteryStatus_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_HPP_
