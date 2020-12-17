// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_HPP_
#define HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.hpp"
// Member 'battery_status'
#include "halodi_msgs/msg/battery_status__struct.hpp"
// Member 'joint_status'
#include "halodi_msgs/msg/joint_status__struct.hpp"
// Member 'motor_status'
#include "halodi_msgs/msg/motor_status__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__RobotStatus __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__RobotStatus __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct RobotStatus_
{
  using Type = RobotStatus_<ContainerAllocator>;

  explicit RobotStatus_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_init),
    battery_status(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->robot_status_level = 0;
      this->backpack_estop_enabled = false;
      this->wireless_estop_enabled = false;
      this->over_temperature = false;
      this->driving_disabled = false;
      this->runtime_since_start = 0ul;
      this->total_runtime = 0ul;
      this->numberOfRuns = 0ul;
    }
  }

  explicit RobotStatus_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_alloc, _init),
    battery_status(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->robot_status_level = 0;
      this->backpack_estop_enabled = false;
      this->wireless_estop_enabled = false;
      this->over_temperature = false;
      this->driving_disabled = false;
      this->runtime_since_start = 0ul;
      this->total_runtime = 0ul;
      this->numberOfRuns = 0ul;
    }
  }

  // field types and members
  using _header_type =
    std_msgs::msg::Header_<ContainerAllocator>;
  _header_type header;
  using _robot_status_level_type =
    unsigned char;
  _robot_status_level_type robot_status_level;
  using _battery_status_type =
    halodi_msgs::msg::BatteryStatus_<ContainerAllocator>;
  _battery_status_type battery_status;
  using _backpack_estop_enabled_type =
    bool;
  _backpack_estop_enabled_type backpack_estop_enabled;
  using _wireless_estop_enabled_type =
    bool;
  _wireless_estop_enabled_type wireless_estop_enabled;
  using _over_temperature_type =
    bool;
  _over_temperature_type over_temperature;
  using _driving_disabled_type =
    bool;
  _driving_disabled_type driving_disabled;
  using _joint_status_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointStatus_<ContainerAllocator>, 30, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointStatus_<ContainerAllocator>>::other>;
  _joint_status_type joint_status;
  using _motor_status_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::MotorStatus_<ContainerAllocator>, 30, typename ContainerAllocator::template rebind<halodi_msgs::msg::MotorStatus_<ContainerAllocator>>::other>;
  _motor_status_type motor_status;
  using _runtime_since_start_type =
    uint32_t;
  _runtime_since_start_type runtime_since_start;
  using _total_runtime_type =
    uint32_t;
  _total_runtime_type total_runtime;
  using _numberOfRuns_type =
    uint32_t;
  _numberOfRuns_type numberOfRuns;

  // setters for named parameter idiom
  Type & set__header(
    const std_msgs::msg::Header_<ContainerAllocator> & _arg)
  {
    this->header = _arg;
    return *this;
  }
  Type & set__robot_status_level(
    const unsigned char & _arg)
  {
    this->robot_status_level = _arg;
    return *this;
  }
  Type & set__battery_status(
    const halodi_msgs::msg::BatteryStatus_<ContainerAllocator> & _arg)
  {
    this->battery_status = _arg;
    return *this;
  }
  Type & set__backpack_estop_enabled(
    const bool & _arg)
  {
    this->backpack_estop_enabled = _arg;
    return *this;
  }
  Type & set__wireless_estop_enabled(
    const bool & _arg)
  {
    this->wireless_estop_enabled = _arg;
    return *this;
  }
  Type & set__over_temperature(
    const bool & _arg)
  {
    this->over_temperature = _arg;
    return *this;
  }
  Type & set__driving_disabled(
    const bool & _arg)
  {
    this->driving_disabled = _arg;
    return *this;
  }
  Type & set__joint_status(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointStatus_<ContainerAllocator>, 30, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointStatus_<ContainerAllocator>>::other> & _arg)
  {
    this->joint_status = _arg;
    return *this;
  }
  Type & set__motor_status(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::MotorStatus_<ContainerAllocator>, 30, typename ContainerAllocator::template rebind<halodi_msgs::msg::MotorStatus_<ContainerAllocator>>::other> & _arg)
  {
    this->motor_status = _arg;
    return *this;
  }
  Type & set__runtime_since_start(
    const uint32_t & _arg)
  {
    this->runtime_since_start = _arg;
    return *this;
  }
  Type & set__total_runtime(
    const uint32_t & _arg)
  {
    this->total_runtime = _arg;
    return *this;
  }
  Type & set__numberOfRuns(
    const uint32_t & _arg)
  {
    this->numberOfRuns = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::RobotStatus_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::RobotStatus_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::RobotStatus_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::RobotStatus_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__RobotStatus
    std::shared_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__RobotStatus
    std::shared_ptr<halodi_msgs::msg::RobotStatus_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const RobotStatus_ & other) const
  {
    if (this->header != other.header) {
      return false;
    }
    if (this->robot_status_level != other.robot_status_level) {
      return false;
    }
    if (this->battery_status != other.battery_status) {
      return false;
    }
    if (this->backpack_estop_enabled != other.backpack_estop_enabled) {
      return false;
    }
    if (this->wireless_estop_enabled != other.wireless_estop_enabled) {
      return false;
    }
    if (this->over_temperature != other.over_temperature) {
      return false;
    }
    if (this->driving_disabled != other.driving_disabled) {
      return false;
    }
    if (this->joint_status != other.joint_status) {
      return false;
    }
    if (this->motor_status != other.motor_status) {
      return false;
    }
    if (this->runtime_since_start != other.runtime_since_start) {
      return false;
    }
    if (this->total_runtime != other.total_runtime) {
      return false;
    }
    if (this->numberOfRuns != other.numberOfRuns) {
      return false;
    }
    return true;
  }
  bool operator!=(const RobotStatus_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct RobotStatus_

// alias to use template instance with default allocator
using RobotStatus =
  halodi_msgs::msg::RobotStatus_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_HPP_
