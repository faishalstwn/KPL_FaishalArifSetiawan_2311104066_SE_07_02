
from ast import Import
import enum
from enumEnum,   # type: ignore
from enum import Enum

class Jeniskelamin(enum.Enum):
    LAKI_LAKI = 1
    PEREMPUAN = 2

patients = []

def add_patient (name: str, gender: Jeniskelamin):
    if not isinstance(gender, Jeniskelamin):
        raise ValueError("Jenis Kelamin harus Jeniskelamin Enum (LAKI_LAKI, PEREMPUAN)")
    patients.append({"name": name, })

add_patient("Andi", Jeniskelamin.LAKI_LAKI)
add_patient("Siti", Jeniskelamin.PEREMPUAN)


for patient in patients:
    print(f"Nama: {patient['name']}, Jenis Kelamin: {patient['gender']}")